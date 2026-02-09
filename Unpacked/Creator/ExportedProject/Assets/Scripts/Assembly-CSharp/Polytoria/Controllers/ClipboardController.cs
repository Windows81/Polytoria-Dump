using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	public class ClipboardController : MonoBehaviour
	{
		public static ClipboardController singleton;

		private const string CLIPBOARD_PREFIX = "POLYTORIA_CLIPBOARD:";

		private const uint GMEM_MOVEABLE = 2u;

		private const uint CF_UNICODETEXT = 13u;

		private void Awake()
		{
		}

		[PreserveSig]
		private static extern bool OpenClipboard(IntPtr hWndNewOwner);

		[PreserveSig]
		private static extern bool CloseClipboard();

		[PreserveSig]
		private static extern bool EmptyClipboard();

		[PreserveSig]
		private static extern IntPtr SetClipboardData(uint uFormat, IntPtr data);

		[PreserveSig]
		private static extern IntPtr GetClipboardData(uint uFormat);

		[PreserveSig]
		private static extern IntPtr GlobalAlloc(uint flags, UIntPtr size);

		[PreserveSig]
		private static extern IntPtr GlobalLock(IntPtr hMem);

		[PreserveSig]
		private static extern bool GlobalUnlock(IntPtr hMem);

		[PreserveSig]
		private static extern IntPtr GlobalFree(IntPtr hMem);

		private static void SetClipboardText(string text)
		{
		}

		private static string GetClipboardText()
		{
			return null;
		}

		public void CopyInstancesToClipboard(List<Instance> instances)
		{
		}

		public void PasteInstancesFromClipboard(Instance targetParent = null)
		{
		}

		private string CompressString(string text)
		{
			return null;
		}

		private string DecompressString(string compressedText)
		{
			return null;
		}
	}
}
