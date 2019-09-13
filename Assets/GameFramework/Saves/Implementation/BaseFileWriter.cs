using PersonalProjects.GameFramework.Saves.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace PersonalProjects.GameFramework.Saves
{
    public class BaseFileWriter : IFileWriter
    {
        public void Write(string path, byte[] data)
        {
            File.WriteAllBytes(path, data);
        }
    }
}