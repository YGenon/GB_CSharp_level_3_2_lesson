using System.Collections.Generic;

namespace MailSender
{
	public static class Senders
	{
		public static Dictionary<string, string> SendersDictionary { get; } = new Dictionary<string, string>
		{
			{"qwe@ewq.ru", EncrypterDll.Encrypter.Deencrypt("123")},
			{"qaz@zaq.ru", EncrypterDll.Encrypter.Deencrypt("3241")}
		};

		public static Dictionary<string, int> ServerDictionary { get; } = new Dictionary<string, int>
		{
			{"smpt.yandex.ru", 25 },
			{"smtp.google.com", 35 }

		};
	}
}