﻿using System.Collections.Generic;
using UnityRipper.Exporter.YAML;

namespace UnityRipper.Classes
{
	public sealed class PackedFloatVector : IStreamReadable, IYAMLExportable
	{
		public void Read(EndianStream stream)
		{
			NumItems = stream.ReadUInt32();
			Range = stream.ReadSingle();
			Start = stream.ReadSingle();
			int size = stream.ReadInt32();
			m_data = new byte[size];
			stream.Read(m_data, 0, size);
			stream.AlignStream(AlignType.Align4);
			BitSize = stream.ReadByte();
			stream.AlignStream(AlignType.Align4);
		}

		public YAMLNode ExportYAML()
		{
			YAMLMappingNode node = new YAMLMappingNode();
			node.Add("m_NumItems", NumItems);
			node.Add("m_Range", Range);
			node.Add("m_Start", Start);
			node.Add("m_Data", Data.ExportYAML());
			node.Add("m_BitSize", BitSize);
			return node;
		}

		public static readonly PackedFloatVector Empty = new PackedFloatVector();

		public uint NumItems { get; private set; }
		public float Range { get; private set; }
		public float Start { get; private set; }
		public IReadOnlyList<byte> Data => m_data;
		public byte BitSize { get; private set; }

		private byte[] m_data = ArrayExtensions.EmptyBytes;
	}
}
