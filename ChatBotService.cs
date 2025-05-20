using ElectronicProductsAPI.Models;
using Newtonsoft.Json;

namespace ElectronicProductsAPI.Services
{
    public class ChatBotService
    {
        private readonly List<KnowledgeEntry> _knowledgeBase;

        public ChatBotService()
        {
            var json = File.ReadAllText("Data/ChatKnowledge.json");
            _knowledgeBase = JsonConvert.DeserializeObject<List<KnowledgeEntry>>(json) ?? new List<KnowledgeEntry>();
        }

        public string GetResponse(string userInput)
        {
            var match = _knowledgeBase.FirstOrDefault(k =>
                userInput.Contains(k.Question, StringComparison.OrdinalIgnoreCase));

            return match?.Answer ?? "أنا آسف، لم أفهم سؤالك. هل يمكنك إعادة صياغته؟";
        }
    }

}