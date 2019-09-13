using PersonalProjects.GameFramework.Saves.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
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
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, data);
                byte[] serializedObject = stream.ToArray();
                fileWriter.Write(savePath, serializedObject);
            }
        }

        public T Load<T>(object data) where T: class
        {
            using (MemoryStream stream = new MemoryStream(fileReader.Read(savePath)))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                T deserializedObject = binaryFormatter.Deserialize(stream) as T;
                return deserializedObject;
            }
        }
    }
}
