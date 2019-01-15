﻿using System.ComponentModel;
using Utils;
using Utils.Document;

namespace Macro.Models
{
    public interface IConfig
    {
        Language Language { get; }
        string SavePath { get; }
        int Period { get; }
        int ProcessDelay { get; }
        int Similarity { get; }
        bool VersionCheck { get; }
    }

    public class Config : IConfig, INotifyPropertyChanged
    {
        private Language _language = Language.Kor;
        private string _savePath = "";
        private int _period = ConstHelper.MinPeriod;
        private int _processDelay = ConstHelper.MinProcessDelay;
        private int _similarity = ConstHelper.DefaultSimilarity;
        private bool _versionCheck = false;

        public Language Language
        {
            get => _language;
            set
            {
                _language = value;
                OnPropertyChanged("Language");
            }
        }

        public string SavePath
        {
            get => _savePath;
            set
            {
                _savePath = value;
                OnPropertyChanged("SavePath");
            }
        }
        public int Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged("Period");
            }
        }
        public int ProcessDelay
        {
            get => _processDelay;
            set
            {
                _processDelay = value;
                OnPropertyChanged("ProcessDelay");
            }
        }
        public int Similarity
        {
            get => _similarity;
            set
            {
                _similarity = value;
                OnPropertyChanged("Similarity");
            }
        }

        public bool VersionCheck
        {
            get => _versionCheck;
            set
            {
                _versionCheck = value;
                OnPropertyChanged("VersionCheck");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
