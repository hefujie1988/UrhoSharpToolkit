﻿using GalaSoft.MvvmLight.Command;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class ProjectReferenceViewModel
    {
        private readonly HubWindowViewModel _parentVm;
        private readonly ProjectReference _reference;

        public ProjectReferenceViewModel(ProjectReference reference, HubWindowViewModel parentVM)
        {
            _reference = reference;
            _parentVm = parentVM;
            Path = _reference.Path;
            Name = _reference.Name;
            if (string.IsNullOrWhiteSpace(Name))
                Name = System.IO.Path.GetFileName(Path);
            OpenCommand = new RelayCommand(OpenProj);
        }

        public RelayCommand OpenCommand { get; set; }

        public string Name { get; set; }
        public string Path { get; set; }

        private void OpenProj()
        {
            _parentVm.OpenProject(_reference, false);
        }
    }
}