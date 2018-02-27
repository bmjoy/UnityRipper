﻿using System.Collections.Generic;

namespace UnityRipper.Classes.Shaders
{
	public sealed class ParserBindChannels : IStreamReadable
	{
		public ParserBindChannels()
		{
		}

		public ParserBindChannels(ShaderBindChannel[] channels, int sourceMap)
		{
			m_channels = channels;
			SourceMap = sourceMap;
		}

		public void Read(EndianStream stream)
		{
			m_channels = stream.ReadArray<ShaderBindChannel>();
			stream.AlignStream(AlignType.Align4);
			SourceMap = stream.ReadInt32();
		}

		public IReadOnlyList<ShaderBindChannel> Channels => m_channels;
		public int SourceMap { get; private set; }

		private ShaderBindChannel[] m_channels;
	}
}
