﻿using System;
using System.IO;

namespace UnityRipper
{
	public static class StreamExtensions
	{
		public static void CopyStream(this Stream _this, Stream dstStream, long size)
		{
			for(long left = size; left > 0; left -= BufferSize)
			{
				int toRead = BufferSize < left ? BufferSize : (int)left;
				int read = _this.Read(s_buffer, 0, toRead);
				if(read != toRead)
				{
					throw new Exception($"Read {read} but expected {toRead}");
				}
				dstStream.Write(s_buffer, 0, read);
			}
		}

		private const int BufferSize = 4096;

		private static byte[] s_buffer = new byte[BufferSize];
	}
}
