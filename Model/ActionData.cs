﻿using System.Text.Json.Serialization;

namespace Godwit.HandleConfirmEmail.Model {
    public class ActionData {
        [JsonPropertyName("input")] public ConfirmEmailModel Input { get; set; }

        [JsonPropertyName("action")] public Action Action { get; set; }

        [JsonPropertyName("session_variables")]
        public Session Session { get; set; }
    }
}