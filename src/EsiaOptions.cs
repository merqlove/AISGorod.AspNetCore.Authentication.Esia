﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;

namespace AISGorod.AspNetCore.Authentication.Esia
{
    /// <summary>
    /// Параметры подключения к ЕСИА.
    /// </summary>
    public class EsiaOptions// : RemoteAuthenticationOptions
    {
        /// <summary>
        /// Среда ЕСИА, с которой происходит подключение.
        /// </summary>
        public EsiaEnvironmentType Environment { get; set; }

        /// <summary>
        /// Мнемоника ИС.
        /// </summary>
        public string Mnemonic { get; set; }

        /// <summary>
        /// Функция, возвращающая сертификат ИС.
        /// Обязательно должен быть закрытый (приватный) ключ.
        /// </summary>
        public Func<X509Certificate2> Certificate { get; set; }

        /// <summary>
        /// Набор scope, которые указаны в заявке на регистрацию системы.
        /// При отсутствии openid он добавляется автоматически.
        /// </summary>
        public ICollection<string> Scope { get; set; }

        /// <summary>
        /// Экземпляр класса HttpClient, с помощью которого будут выполняться запросы.
        /// Полезно, если требуется настроить работу с прокси.
        /// </summary>
        public HttpClient Backchannel { get; set; }
    }
}