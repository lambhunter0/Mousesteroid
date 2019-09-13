using PersonalProjects.GameFramework.Saves.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PersonalProjects.GameFramework.Saves
{
    public class Saves
    {
        private readonly string savePath;
        private IFileReader fileReader;
        private IFileWriter fileWriter;

        public Saves(IFileReader fileReader, IFileWriter fileWriter)
        {
            savePath = Application.persistentDataPath + "/save.dat"; //TODO: change?
            this.fileReader = fileReader;
            this.fileWriter = fileWriter;
        }

        public Saves()
        {
            fileReader = new BaseFileReader();
            fileWriter = new BaseFileWriter();
        }

        public void Save(object data)
        {
            //TODO
        }

        public void Load(object data)
        {
            //TODO
        }
    }
}
