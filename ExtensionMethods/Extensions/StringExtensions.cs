namespace System;

static class StringExtensions {
    public static string Cut(this String thisObj, int length) {
        if (thisObj.Length <= length) {
            return thisObj;
        }
        
        return thisObj.Substring(0, length) + "...";
    }
}