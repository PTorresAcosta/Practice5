﻿using System.Text.Json;

namespace Practice5WebApp.Data
{
    public class WebApiException : Exception
    {

        public ErrorResponse? ErrorResponse { get; set; }

        public WebApiException(string errorJson)
        {
            ErrorResponse = JsonSerializer.Deserialize<ErrorResponse>(errorJson);
        }

    }
}
