using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PreviewSocialNetwork.Domain.Interfaces;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace PreviewSocialNetwork.App.Services
{
    public class VkService : IServiceSocialNetwork
    {
        /// <summary>
        /// Идентификатор клиента (приложения).
        /// </summary>
        private ulong AppId { get; set; }
        /// <summary>
        /// Логин.
        /// </summary>
        private string Login { get; set; }
        /// <summary>
        /// Пароль.
        /// </summary>
        private string Password { get; set; }
        /// <summary>
        /// Токен для взаимодействия с апи.
        /// </summary>
        private string AccessToken { get; set; }
        /// <summary>
        /// Идентификатор группы.
        /// </summary>
        private string GroupId { get; set; }

        /// <summary>
        /// Конструктор с default значениями.
        /// </summary>
        public VkService()
        {
            AppId = 7812833;
            Login = "+79506070376";
            Password = "ShI1Y*H@kAt0N";
            GroupId = "203749939";
            AccessToken = Authorization(AppId, Login, Password);
        }

        /// <summary>
        /// Метод отправки сообщения на социальные сети.
        /// </summary>
        /// <param name="message">Анонс.</param>
        /// <returns>true - сообщение отправлено успешно, false - ошибка отправки.</returns>
        public bool SendSocialNetwork(IMessagePreview message)
        {
            if (string.IsNullOrWhiteSpace(AccessToken)) return false;
            
            var client = new HttpClient();

            var text = message.MessageText;

            var response = client.GetAsync($"https://api.vk.com/method/wall.post?owner_id=-{GroupId}&from_group=1&message={text}&access_token={AccessToken}&v=5.130").Result;

            return Regex.IsMatch(response.Content.ReadAsStringAsync().Result, "(?<=\"post_id\":)[0-9]+") ? true : false;
        }

        /// <summary>
        /// Авторизация через логин и пароль.
        /// </summary>
        /// <param name="AppId">Идентификатор приложения.</param>
        /// <param name="Login">Логин.</param>
        /// <param name="Password">Пароль.</param>
        /// <returns></returns>
        private static string Authorization(ulong AppId, string Login, string Password)
        {
            var vkApi = new VkApi();

            vkApi.Authorize(new ApiAuthParams
            {
                ApplicationId = AppId,
                Login = Login,
                Password = Password,
                Settings = Settings.All
            });

            return vkApi.Token;
        }

        /// <summary>
        /// Авторизация через accessToken (VkNet).
        /// </summary>
        /// <param name="accessToken">Старый accessToken (токен от прошлой авторизации).</param>
        /// <returns></returns>
        private static string AuthorizationVkNet(string accessToken)
        {
            var vkApi = new VkApi();

            vkApi.Authorize(new ApiAuthParams
            {
                AccessToken = accessToken
            });

            return vkApi.Token;
        }
    }
}
