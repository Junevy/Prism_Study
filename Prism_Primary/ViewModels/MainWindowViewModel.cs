using Prism.Commands;
using Prism.Mvvm;
using Prism_Primary.Models;
using System;
using System.Windows;

namespace Prism_Primary.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        /// <summary>
        /// SetProperty 添加值更改后回调
        /// </summary>
        private string title = "Prism Application";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value, () =>
            {
                MessageBox.Show("Title Changed to: " + title);
            }); }
        }
        public DelegateCommand ChangeCommand => new(() =>
        {
            Title = DateTime.Now.ToString("HH:mm:ss");
        });

        /// <summary>
        /// 带参Command
        /// </summary>
        private string message = "Welcome to Prism!";
        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }
        public DelegateCommand<string> ChangeMsgCommand => new((msg) =>
        {
            Message = msg;
        });

        /// <summary>
        /// 传递复杂对象（参数）
        /// </summary>
        public UserInfo Info { get; set; } = new();
        public DelegateCommand<UserInfo> GetUserInfoCommand => new((info) =>
        {
            MessageBox.Show($"Name: {Info.Name}, Age: {Info.Age}");
        });


    }
}
