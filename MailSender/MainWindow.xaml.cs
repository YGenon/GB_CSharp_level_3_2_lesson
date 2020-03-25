using EmailSend;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace MailSender
{
	public partial class MainWindow : Window
	{
		private EmailSendServiceClass _emailSender;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void TabSwitcherControl_OnBack(object sender, RoutedEventArgs e)
		{
			if (MainTabControl.SelectedIndex == 0) return;
			MainTabControl.SelectedIndex--;
		}

		private void TabSwitcherControl_OnForward(object sender, RoutedEventArgs e)
		{
			if (MainTabControl.SelectedIndex == MainTabControl.Items.Count - 1) return;
			MainTabControl.SelectedIndex++;
		}

		private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
		{
			KeyValuePair<string, string> item = (KeyValuePair<string, string>) cbSenderSelect.SelectionBoxItem;
			//MessageBox.Show(item.Value);
			string strLogin = cbSenderSelect.Text;
			string strPassword = cbSenderSelect.SelectedValue.ToString();
			if (string.IsNullOrEmpty(strLogin))
			{
				MessageBox.Show("Выберите отправителя");
				return;
			}
			if (string.IsNullOrEmpty(strPassword))
			{
				MessageBox.Show("Укажите пароль отправителя");
				return;
			}

			// берем настройки smtp сервера
			KeyValuePair<string, int> item2 = (KeyValuePair<string, int>)cbServerSelect.SelectionBoxItem;
			string strSmtp = item2.Key.ToString();
			int strPort = Convert.ToInt32(item2.Value);
			// проверяем что правильно передали параметры SMTP Servera
			//MessageBox.Show(strSmtp + " : " + strPort);

			// проверяем RichTextBox на наличие текста			
			if (new TextRange(RichText.Document.ContentStart, RichText.Document.ContentEnd).Text.Length < 3)
			{
				MessageBox.Show("Письмо не заполнено!");
				MainTabControl.SelectedIndex++; 
				return;
			}

			MessageBox.Show("отправлено");
			_emailSender = new EmailSend.EmailSendServiceClass(strLogin, strPassword, strSmtp, strPort);
			
			//_emailSender.SendMails((IQueryable<Emails>)dgEmails.ItemsSource);

		}
	}
}
