# System.Speech.AudioFormat

``` diff
+namespace System.Speech.AudioFormat {
+    public enum AudioBitsPerSample {
+        Eight = 8,
+        Sixteen = 16,
+    }
+    public enum AudioChannel {
+        Mono = 1,
+        Stereo = 2,
+    }
+    public enum EncodingFormat {
+        ALaw = 6,
+        Pcm = 1,
+        ULaw = 7,
+    }
+    public class SpeechAudioFormatInfo {
+        public SpeechAudioFormatInfo(int samplesPerSecond, AudioBitsPerSample bitsPerSample, AudioChannel channel);
+        public SpeechAudioFormatInfo(EncodingFormat encodingFormat, int samplesPerSecond, int bitsPerSample, int channelCount, int averageBytesPerSecond, int blockAlign, byte[] formatSpecificData);
+        public int AverageBytesPerSecond { get; }
+        public int BitsPerSample { get; }
+        public int BlockAlign { get; }
+        public int ChannelCount { get; }
+        public EncodingFormat EncodingFormat { get; }
+        public int SamplesPerSecond { get; }
+        public override bool Equals(object obj);
+        public byte[] FormatSpecificData();
+        public override int GetHashCode();
+    }
+}
```

