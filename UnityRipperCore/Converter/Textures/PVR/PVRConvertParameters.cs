﻿namespace UnityRipper.Converter.Textures.PVR
{
	public struct PVRConvertParameters
	{
		public int DataLength { get; set; }
		public PVRPixelFormat PixelFormat { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public int MipMapCount { get; set; }
	}
}
