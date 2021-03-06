﻿namespace CloudinaryDotNet
{
    public class CSource
    {
        public CSource(string source)
        {
            SourceToSign = Source = source;
        }

        public static CSource operator +(CSource src, string value)
        {
            src.Source += value;
            src.SourceToSign += value;

            return src;
        }

        public string Source;
        public string SourceToSign;
    }
}
