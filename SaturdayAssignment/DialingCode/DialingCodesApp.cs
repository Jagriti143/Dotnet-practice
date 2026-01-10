using System;
using System.Collections;
using System.Collections.Generic;
namespace DT{
    public static class DialingCodes{
        public static Dictionary<int,string> GetEmptyDictionary(){
        Dictionary<int, string> dict=new Dictionary<int,string>();
        return dict;
        }
        public static Dictionary<int, string> GetExistingDictionary(){
            Dictionary<int,string> ds=new Dictionary<int,string>();

                ds.Add(1,"United States of America");
                ds.Add(2,"Brazil");
                ds.Add(3,"India");
            return ds;
        }
        public static Dictionary<int,string> AddCountryToEmptyDictionary(int code,string name){
            Dictionary<int,string> ds2=new Dictionary<int,string>();
            
            ds2.Add(code,name);
            
            return ds2;
        }
        public static Dictionary<int,string> AddCountryToExistingDictionary(Dictionary<int,string> ds, int code,string name){
                ds.Add(code,name);
            
            return ds;
        }
        public static string GetCountryNameFromDictionary(Dictionary<int,string> ds,int code){
                if(ds.ContainsKey(code)){
                    return ds[code];
                }
            return "";
        }
        public static bool CheckCodeExists(Dictionary<int,string> ds,int code){
            if(ds.ContainsKey(code)){
                return true;
            }
            return false;
        }
        public static Dictionary<int,string> UpdateDictionary(Dictionary<int,string> ds,int code,string name){
            if(ds.ContainsKey(code)){
                ds[code]=name;
                return ds;
            }
            return ds;
        }
        public static Dictionary<int,string> RemoveCountryFromDictionary(Dictionary<int,string> ds, int code){
            if(ds.ContainsKey(code)){
                ds.Remove(code);
            }
            return ds;
        }
        
        public static string FindLongestCountryName(Dictionary<int,string> ds){
            string max="";
            foreach(var i in ds){
                if(i.Value.Length >max.Length){
                    max=i.Value;
                }
            }
            return max;

        }


    }

}