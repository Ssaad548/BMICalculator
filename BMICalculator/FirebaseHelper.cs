using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.Maui.Storage;


namespace BMICalculator
{
    internal class FirebaseHelper
    {
        FirebaseClient firebase = new FirebaseClient("https://bmicalculator-e0078-default-rtdb.asia-southeast1.firebasedatabase.app/");


        public async Task AddRecord(string dt, double w, double br, string bs)
        {
            await firebase
            .Child("BMIRecords")
            .PostAsync(new BMIRecord() { DateRecorded = dt, Weight = w, BMIResult = br, BMIStatus = bs });
        }

        public async Task<List<BMIRecord>> GetAllBMIRecord()
        {
            return (await firebase
            .Child("BMIRecords")
            .OnceAsync<BMIRecord>()).Select(item => new BMIRecord
            {
                DateRecorded = item.Object.DateRecorded,
                Weight = item.Object.Weight,
                BMIResult = item.Object.BMIResult,
                BMIStatus = item.Object.BMIStatus
            }).ToList();
        }
    }
}
