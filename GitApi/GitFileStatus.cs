﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.IO;
using System.Runtime.Remoting.Messaging;
using LibGit2Sharp;

namespace GitScc
{
    public enum GitFileStatus
    {
        NotControlled,
        New,
        Tracked,
        Modified,
        Staged,
        Removed,
        Added,
        Deleted,
        Conflict,
        Merged,
        Ignored,
        Renamed,
        Copied,
        Nonexistent,
        Unaltered,
        Unreadable
    }

    public class GitFile : INotifyPropertyChanged
    {
        private string _fileName;
        private string _path;
        private const string PATH_STRING = @"{0}{1}";
        private GitFileStatus _gitFileStatus;

        public GitFile(Repository repository, StatusEntry fileStatusEntry)
        {
            FileStatusEntry = fileStatusEntry;
            _path = Path.GetFullPath(string.Format(PATH_STRING, repository.Info.WorkingDirectory, FileStatusEntry.FilePath));
        }

        public StatusEntry FileStatusEntry { get; set; }


        public string FilePath
        {
            get { return _path; }
        }
        public string FileName
        {
            get
            {
                return FileStatusEntry.FilePath;
            }
        }
        public bool IsStaged {
            get
            {
                return Status == GitFileStatus.Added ||
                       Status == GitFileStatus.Staged ||
                       Status == GitFileStatus.Removed ||
                       Status == GitFileStatus.Renamed;
            }
        }


        public GitFileStatus Status
        {
            get
            {
                var state = FileStatusEntry.State;
 
                if (state == FileStatus.ModifiedInIndex  || state.HasFlag(FileStatus.ModifiedInIndex))
                {
                    return GitFileStatus.Staged;
                }
                if (state == FileStatus.ModifiedInWorkdir || state.HasFlag(FileStatus.ModifiedInWorkdir))
                {
                    return GitFileStatus.Modified;
                }
                if (state == FileStatus.TypeChangeInWorkdir || state.HasFlag(FileStatus.TypeChangeInWorkdir))
                {
                    return GitFileStatus.Modified;
                }
                if (state == FileStatus.TypeChangeInIndex || state.HasFlag(FileStatus.TypeChangeInIndex))
                {
                    return GitFileStatus.Modified;
                }

                switch (FileStatusEntry.State)
                {
                    case FileStatus.Nonexistent:
                        return GitFileStatus.Nonexistent;
                    case FileStatus.Unaltered:
                        return GitFileStatus.Unaltered;
                    case FileStatus.NewInIndex:
                        return GitFileStatus.Added;
                    case FileStatus.ModifiedInIndex:
                        return GitFileStatus.Staged;
                    case FileStatus.DeletedFromIndex:
                        return GitFileStatus.Removed;
                    case FileStatus.RenamedInIndex:
                        return GitFileStatus.Renamed;
                    case FileStatus.NewInWorkdir:
                        return GitFileStatus.New;
                    case FileStatus.DeletedFromWorkdir:
                        return GitFileStatus.Deleted;
                    case FileStatus.RenamedInWorkdir:
                        return GitFileStatus.Renamed;
                    case FileStatus.Unreadable:
                        return GitFileStatus.Unreadable; 
                    case FileStatus.Ignored:
                        return GitFileStatus.Ignored;
                    default:
                        return GitFileStatus.Ignored;
                }
            }
        }

        public bool Changed
        {
            get
            {
                switch (Status)
                {
                    case GitFileStatus.NotControlled:
                        return false;
                    case GitFileStatus.New:
                        return true;
                    case GitFileStatus.Tracked:
                        return true;
                    case GitFileStatus.Modified:
                        return true;
                    case GitFileStatus.Staged:
                        return true;
                    case GitFileStatus.Removed:
                        return true;
                    case GitFileStatus.Added:
                        return true;
                    case GitFileStatus.Deleted:
                        return true;
                    case GitFileStatus.Conflict:
                        return true;
                    case GitFileStatus.Merged:
                        return true;
                    case GitFileStatus.Ignored:
                        return false;
                    case GitFileStatus.Renamed:
                        return true;
                    case GitFileStatus.Copied:
                        return true;
                    case GitFileStatus.Nonexistent:
                        return false;
                    case GitFileStatus.Unaltered:
                        return false;
                    case GitFileStatus.Unreadable:
                        return false;
                    default:
                        return false;
                }
            }
        }

        public bool isSelected;

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
