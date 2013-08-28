using UnityEngine;
using System;
using System.Collections;
using BinFoo.UniPlugin.Audio.Converter;

namespace BinFoo.UniPlugin.Audio
{
	public class ACxAudioClip
	{
		/// <summary>
		/// Convert bytes to audioclip
		/// </summary>
		/// <returns>
		/// AudioClip
		/// </returns>
		/// <param name='_bitstream'>
		/// _bitstream.
		/// </param>
		/// 
		/// <example>
		/// <code>
		/// byte[] data = File.ReadAll("a.mp3");
		/// ACxAudioClip acx = new ACxAudioClip();
		/// AudioClip ac = acx.FromMP3(data);
		/// </code>
		/// </example>
		public AudioClip FromMP3(byte[] _bitstream)
		{
			ACxMP3Converter converter = new ACxMP3Converter();
			return converter.Convert(_bitstream);
		}
		
		public AudioClip FromWAV(byte[] _bitstream)
		{
			throw new NotImplementedException("FromWAV");
		}
		
		public AudioClip FromOGG(byte[] _bitstream)
		{
			throw new NotImplementedException("FromOGG");
		}
		
	}//class
}//namespace