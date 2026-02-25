namespace Discord;

[Token(Token = "0x2000294")]
public class OverlayManager
{
	[Token(Token = "0x2000295")]
	public struct FFIEvents
	{
		[Token(Token = "0x2000296")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ToggleHandler : MulticastDelegate
		{

			[Address(RVA = "0x3ADFE0", Offset = "0x3AD1E0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x60012C9")]
			public ToggleHandler(object object, IntPtr method) { }

			[Address(RVA = "0x3A1880", Offset = "0x3A0A80", Length = "0x6F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012CB")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, bool locked, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012CC")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012CA")]
			public override void Invoke(IntPtr ptr, bool locked) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007D9")]
		internal ToggleHandler OnToggle; //Field offset: 0x0

	}

	[Token(Token = "0x2000297")]
	public struct FFIMethods
	{
		[Token(Token = "0x20002A6")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CharEventMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001305")]
			public CharEventMethod(object object, IntPtr method) { }

			[Address(RVA = "0x38E2C0", Offset = "0x38D4C0", Length = "0x66")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001307")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string character, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001308")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001306")]
			public override void Invoke(IntPtr methodsPtr, string character) { }

		}

		[Token(Token = "0x20002A4")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ForwardMessageMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012FD")]
			public ForwardMessageMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A54B0", Offset = "0x3A46B0", Length = "0x6F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012FF")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr message, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001300")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012FE")]
			public override void Invoke(IntPtr methodsPtr, IntPtr message) { }

		}

		[Token(Token = "0x20002AB")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ImeCancelCompositionMethod : MulticastDelegate
		{

			[Address(RVA = "0x391F20", Offset = "0x391120", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001319")]
			public ImeCancelCompositionMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600131B")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600131C")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600131A")]
			public override void Invoke(IntPtr methodsPtr) { }

		}

		[Token(Token = "0x20002A9")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ImeCommitTextMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001311")]
			public ImeCommitTextMethod(object object, IntPtr method) { }

			[Address(RVA = "0x38E2C0", Offset = "0x38D4C0", Length = "0x66")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001313")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string text, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001314")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001312")]
			public override void Invoke(IntPtr methodsPtr, string text) { }

		}

		[Token(Token = "0x20002AA")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ImeSetCompositionMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A5C50", Offset = "0x3A4E50", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6001315")]
			public ImeSetCompositionMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5B80", Offset = "0x3A4D80", Length = "0xD0")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001317")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string text, ref ImeUnderline underlines, int from, int to, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001318")]
			public override void EndInvoke(ref ImeUnderline underlines, IAsyncResult result) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001316")]
			public override void Invoke(IntPtr methodsPtr, string text, ref ImeUnderline underlines, int from, int to) { }

		}

		[Token(Token = "0x20002A2")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class InitDrawingDxgiMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A4C80", Offset = "0x3A3E80", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F5")]
			public InitDrawingDxgiMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5D00", Offset = "0x3A4F00", Length = "0x7F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012F7")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr swapchain, bool useMessageForwarding, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F8")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F6")]
			public override Result Invoke(IntPtr methodsPtr, IntPtr swapchain, bool useMessageForwarding) { }

		}

		[Token(Token = "0x2000298")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class IsEnabledMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012CD")]
			public IsEnabledMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5D80", Offset = "0x3A4F80", Length = "0x75")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012CF")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool enabled, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012D0")]
			public override void EndInvoke(ref bool enabled, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012CE")]
			public override void Invoke(IntPtr methodsPtr, ref bool enabled) { }

		}

		[Token(Token = "0x2000299")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class IsLockedMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012D1")]
			public IsLockedMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5D80", Offset = "0x3A4F80", Length = "0x75")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012D3")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref bool locked, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012D4")]
			public override void EndInvoke(ref bool locked, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012D2")]
			public override void Invoke(IntPtr methodsPtr, ref bool locked) { }

		}

		[Token(Token = "0x20002B0")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class IsPointInsideClickZoneMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A5EB0", Offset = "0x3A50B0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x600132D")]
			public IsPointInsideClickZoneMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5E00", Offset = "0x3A5000", Length = "0x7F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600132F")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int x, int y, AsyncCallback callback, object object) { }

			[Address(RVA = "0x3A5E80", Offset = "0x3A5080", Length = "0x28")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001330")]
			public override bool EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600132E")]
			public override bool Invoke(IntPtr methodsPtr, int x, int y) { }

		}

		[Token(Token = "0x20002A5")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class KeyEventMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A6020", Offset = "0x3A5220", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6001301")]
			public KeyEventMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5F60", Offset = "0x3A5160", Length = "0xB1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001303")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, bool down, string keyCode, KeyVariant variant, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001304")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001302")]
			public override void Invoke(IntPtr methodsPtr, bool down, string keyCode, KeyVariant variant) { }

		}

		[Token(Token = "0x20002A7")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class MouseButtonEventMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A6630", Offset = "0x3A5830", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6001309")]
			public MouseButtonEventMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A6530", Offset = "0x3A5730", Length = "0xF2")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600130B")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, byte down, int clickCount, MouseButton which, int x, int y, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600130C")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3359C0", Offset = "0x334BC0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600130A")]
			public override void Invoke(IntPtr methodsPtr, byte down, int clickCount, MouseButton which, int x, int y) { }

		}

		[Token(Token = "0x20002A8")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class MouseMotionEventMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A66E0", Offset = "0x3A58E0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x600130D")]
			public MouseMotionEventMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5E00", Offset = "0x3A5000", Length = "0x7F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600130F")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int x, int y, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001310")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600130E")]
			public override void Invoke(IntPtr methodsPtr, int x, int y) { }

		}

		[Token(Token = "0x20002A3")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OnPresentMethod : MulticastDelegate
		{

			[Address(RVA = "0x391F20", Offset = "0x391120", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F9")]
			public OnPresentMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391EC0", Offset = "0x3910C0", Length = "0x5F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012FB")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012FC")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
			[CallerCount(Count = 3)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012FA")]
			public override void Invoke(IntPtr methodsPtr) { }

		}

		[Token(Token = "0x200029C")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OpenActivityInviteCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012DD")]
			public OpenActivityInviteCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A77E0", Offset = "0x3A69E0", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012DF")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012E0")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012DE")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x200029D")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OpenActivityInviteMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E160", Offset = "0x38D360", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012E1")]
			public OpenActivityInviteMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A78F0", Offset = "0x3A6AF0", Length = "0xAE")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012E3")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OpenActivityInviteCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012E4")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012E2")]
			public override void Invoke(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OpenActivityInviteCallback callback) { }

		}

		[Token(Token = "0x200029E")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OpenGuildInviteCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012E5")]
			public OpenGuildInviteCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A7A40", Offset = "0x3A6C40", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012E7")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012E8")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012E6")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x200029F")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OpenGuildInviteMethod : MulticastDelegate
		{

			[Address(RVA = "0x38DEF0", Offset = "0x38D0F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012E9")]
			public OpenGuildInviteMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391850", Offset = "0x390A50", Length = "0x89")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012EB")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string code, IntPtr callbackData, OpenGuildInviteCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012EC")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012EA")]
			public override void Invoke(IntPtr methodsPtr, string code, IntPtr callbackData, OpenGuildInviteCallback callback) { }

		}

		[Token(Token = "0x20002A0")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OpenVoiceSettingsCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012ED")]
			public OpenVoiceSettingsCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A7BD0", Offset = "0x3A6DD0", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012EF")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F0")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012EE")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x20002A1")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class OpenVoiceSettingsMethod : MulticastDelegate
		{

			[Address(RVA = "0x391240", Offset = "0x390440", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F1")]
			public OpenVoiceSettingsMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3911C0", Offset = "0x3903C0", Length = "0x76")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F3")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, OpenVoiceSettingsCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F4")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012F2")]
			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, OpenVoiceSettingsCallback callback) { }

		}

		[Token(Token = "0x20002AC")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetImeCompositionRangeCallbackCallback : MulticastDelegate
		{

			[Address(RVA = "0x3AA030", Offset = "0x3A9230", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x600131D")]
			public SetImeCompositionRangeCallbackCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A9F70", Offset = "0x3A9170", Length = "0xBA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600131F")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, int from, int to, ref Rect bounds, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001320")]
			public override void EndInvoke(ref Rect bounds, IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600131E")]
			public override void Invoke(IntPtr ptr, int from, int to, ref Rect bounds) { }

		}

		[Token(Token = "0x20002AD")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetImeCompositionRangeCallbackMethod : MulticastDelegate
		{

			[Address(RVA = "0x391240", Offset = "0x390440", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001321")]
			public SetImeCompositionRangeCallbackMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3911C0", Offset = "0x3903C0", Length = "0x76")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001323")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, SetImeCompositionRangeCallbackCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001324")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001322")]
			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, SetImeCompositionRangeCallbackCallback callback) { }

		}

		[Token(Token = "0x20002AE")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetImeSelectionBoundsCallbackCallback : MulticastDelegate
		{

			[Address(RVA = "0x3AA350", Offset = "0x3A9550", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6001325")]
			public SetImeSelectionBoundsCallbackCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3AA230", Offset = "0x3A9430", Length = "0xC6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001327")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001328")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3AA300", Offset = "0x3A9500", Length = "0x45")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6001326")]
			public override void Invoke(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst) { }

		}

		[Token(Token = "0x20002AF")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetImeSelectionBoundsCallbackMethod : MulticastDelegate
		{

			[Address(RVA = "0x391240", Offset = "0x390440", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001329")]
			public SetImeSelectionBoundsCallbackMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3911C0", Offset = "0x3903C0", Length = "0x76")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x600132B")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr callbackData, SetImeSelectionBoundsCallbackCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600132C")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600132A")]
			public override void Invoke(IntPtr methodsPtr, IntPtr callbackData, SetImeSelectionBoundsCallbackCallback callback) { }

		}

		[Token(Token = "0x200029A")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetLockedCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012D5")]
			public SetLockedCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3AA960", Offset = "0x3A9B60", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012D7")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012D8")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012D6")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x200029B")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetLockedMethod : MulticastDelegate
		{

			[Address(RVA = "0x3AAB10", Offset = "0x3A9D10", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x60012D9")]
			public SetLockedMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3AAA70", Offset = "0x3A9C70", Length = "0x92")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60012DB")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, IntPtr callbackData, SetLockedCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60012DC")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60012DA")]
			public override void Invoke(IntPtr methodsPtr, bool locked, IntPtr callbackData, SetLockedCallback callback) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007DA")]
		internal IsEnabledMethod IsEnabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007DB")]
		internal IsLockedMethod IsLocked; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007DC")]
		internal SetLockedMethod SetLocked; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007DD")]
		internal OpenActivityInviteMethod OpenActivityInvite; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007DE")]
		internal OpenGuildInviteMethod OpenGuildInvite; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007DF")]
		internal OpenVoiceSettingsMethod OpenVoiceSettings; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007E0")]
		internal InitDrawingDxgiMethod InitDrawingDxgi; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40007E1")]
		internal OnPresentMethod OnPresent; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40007E2")]
		internal ForwardMessageMethod ForwardMessage; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40007E3")]
		internal KeyEventMethod KeyEvent; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40007E4")]
		internal CharEventMethod CharEvent; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x40007E5")]
		internal MouseButtonEventMethod MouseButtonEvent; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40007E6")]
		internal MouseMotionEventMethod MouseMotionEvent; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x40007E7")]
		internal ImeCommitTextMethod ImeCommitText; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40007E8")]
		internal ImeSetCompositionMethod ImeSetComposition; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40007E9")]
		internal ImeCancelCompositionMethod ImeCancelComposition; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40007EA")]
		internal SetImeCompositionRangeCallbackMethod SetImeCompositionRangeCallback; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40007EB")]
		internal SetImeSelectionBoundsCallbackMethod SetImeSelectionBoundsCallback; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x40007EC")]
		internal IsPointInsideClickZoneMethod IsPointInsideClickZone; //Field offset: 0x90

	}

	[Token(Token = "0x20002B2")]
	internal sealed class OpenActivityInviteHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001335")]
		public OpenActivityInviteHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A7870", Offset = "0x3A6A70", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001337")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001338")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001336")]
		public override void Invoke(Result result) { }

	}

	[Token(Token = "0x20002B3")]
	internal sealed class OpenGuildInviteHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001339")]
		public OpenGuildInviteHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A7AD0", Offset = "0x3A6CD0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x600133B")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600133C")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600133A")]
		public override void Invoke(Result result) { }

	}

	[Token(Token = "0x20002B4")]
	internal sealed class OpenVoiceSettingsHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600133D")]
		public OpenVoiceSettingsHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A7C60", Offset = "0x3A6E60", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x600133F")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001340")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600133E")]
		public override void Invoke(Result result) { }

	}

	[Token(Token = "0x20002B5")]
	internal sealed class SetImeCompositionRangeCallbackHandler : MulticastDelegate
	{

		[Address(RVA = "0x3AA180", Offset = "0x3A9380", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001341")]
		public SetImeCompositionRangeCallbackHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3AA0E0", Offset = "0x3A92E0", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001343")]
		public override IAsyncResult BeginInvoke(int from, int to, ref Rect bounds, AsyncCallback callback, object object) { }

		[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001344")]
		public override void EndInvoke(ref Rect bounds, IAsyncResult result) { }

		[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001342")]
		public override void Invoke(int from, int to, ref Rect bounds) { }

	}

	[Token(Token = "0x20002B6")]
	internal sealed class SetImeSelectionBoundsCallbackHandler : MulticastDelegate
	{

		[Address(RVA = "0x3AA4F0", Offset = "0x3A96F0", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6001345")]
		public SetImeSelectionBoundsCallbackHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3AA400", Offset = "0x3A9600", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001347")]
		public override IAsyncResult BeginInvoke(Rect anchor, Rect focus, bool isAnchorFirst, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001348")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x3AA4B0", Offset = "0x3A96B0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001346")]
		public override void Invoke(Rect anchor, Rect focus, bool isAnchorFirst) { }

	}

	[Token(Token = "0x20002B1")]
	internal sealed class SetLockedHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001331")]
		public SetLockedHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3AA9F0", Offset = "0x3A9BF0", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001333")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001334")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001332")]
		public override void Invoke(Result result) { }

	}

	[Token(Token = "0x20002B7")]
	internal sealed class ToggleHandler : MulticastDelegate
	{

		[Address(RVA = "0x3ADF30", Offset = "0x3AD130", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001349")]
		public ToggleHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3ADED0", Offset = "0x3AD0D0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x600134B")]
		public override IAsyncResult BeginInvoke(bool locked, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600134C")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600134A")]
		public override void Invoke(bool locked) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007D6")]
	private IntPtr MethodsPtr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007D7")]
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007D8")]
	private ToggleHandler OnToggle; //Field offset: 0x20

	[Token(Token = "0x14000012")]
	public event ToggleHandler OnToggle
	{
		[Address(RVA = "0x3A9630", Offset = "0x3A8830", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60012AB")]
		 add { } //Length: 158
		[Address(RVA = "0x3A9830", Offset = "0x3A8A30", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x60012AC")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x170001E8")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x3A96D0", Offset = "0x3A88D0", Length = "0x15A")]
		[CalledBy(Type = typeof(OverlayManager), Member = "MouseMotionEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "IsPointInsideClickZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(OverlayManager), Member = "SetImeSelectionBoundsCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetImeSelectionBoundsCallbackHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "SetImeCompositionRangeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetImeCompositionRangeCallbackHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "ImeCancelComposition", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "ImeSetComposition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ImeUnderline), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "ImeCommitText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "MouseButtonEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(MouseButton), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "CharEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "KeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string), typeof(KeyVariant)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "OnPresent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "InitDrawingDxgi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "OpenVoiceSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenVoiceSettingsHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "OpenGuildInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OpenGuildInviteHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "OpenActivityInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityActionType), typeof(OpenActivityInviteHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "SetLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(SetLockedHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(OverlayManager), Member = "IsLocked", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(OverlayManager), Member = "IsEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(OverlayManager), Member = "ForwardMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		[CallerCount(Count = 19)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x60012AA")]
		private get { } //Length: 346
	}

	[Address(RVA = "0x3A9440", Offset = "0x3A8640", Length = "0x1E9")]
	[CalledBy(Type = typeof(Discord), Member = "GetOverlayManager", ReturnType = typeof(OverlayManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012AD")]
	internal OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3A9630", Offset = "0x3A8830", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60012AB")]
	public void add_OnToggle(ToggleHandler value) { }

	[Address(RVA = "0x3A7CE0", Offset = "0x3A6EE0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BD")]
	public void CharEvent(string character) { }

	[Address(RVA = "0x3A7D40", Offset = "0x3A6F40", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BB")]
	public void ForwardMessage(IntPtr message) { }

	[Address(RVA = "0x3A96D0", Offset = "0x3A88D0", Length = "0x15A")]
	[CalledBy(Type = typeof(OverlayManager), Member = "ForwardMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "IsEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OverlayManager), Member = "IsLocked", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OverlayManager), Member = "SetLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(SetLockedHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "OpenActivityInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ActivityActionType), typeof(OpenActivityInviteHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "OpenVoiceSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenVoiceSettingsHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "InitDrawingDxgi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "OnPresent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "KeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string), typeof(KeyVariant)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "OpenGuildInvite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OpenGuildInviteHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "MouseButtonEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(int), typeof(MouseButton), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "ImeCommitText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "ImeSetComposition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ImeUnderline), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "CharEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "ImeCancelComposition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "SetImeCompositionRangeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetImeCompositionRangeCallbackHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "SetImeSelectionBoundsCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SetImeSelectionBoundsCallbackHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OverlayManager), Member = "IsPointInsideClickZone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OverlayManager), Member = "MouseMotionEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Token(Token = "0x60012AA")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x3A7DA0", Offset = "0x3A6FA0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012C2")]
	public void ImeCancelComposition() { }

	[Address(RVA = "0x3A7DF0", Offset = "0x3A6FF0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012C0")]
	public void ImeCommitText(string text) { }

	[Address(RVA = "0x3A7E50", Offset = "0x3A7050", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012C1")]
	public void ImeSetComposition(string text, ImeUnderline underlines, int from, int to) { }

	[Address(RVA = "0x3A7EE0", Offset = "0x3A70E0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B9")]
	public void InitDrawingDxgi(IntPtr swapchain, bool useMessageForwarding) { }

	[Address(RVA = "0x3A7FA0", Offset = "0x3A71A0", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60012AE")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3A80F0", Offset = "0x3A72F0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012AF")]
	public bool IsEnabled() { }

	[Address(RVA = "0x3A8150", Offset = "0x3A7350", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B0")]
	public bool IsLocked() { }

	[Address(RVA = "0x3A81C0", Offset = "0x3A73C0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012C7")]
	public bool IsPointInsideClickZone(int x, int y) { }

	[Address(RVA = "0x3A8230", Offset = "0x3A7430", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BC")]
	public void KeyEvent(bool down, string keyCode, KeyVariant variant) { }

	[Address(RVA = "0x3A82B0", Offset = "0x3A74B0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BE")]
	public void MouseButtonEvent(byte down, int clickCount, MouseButton which, int x, int y) { }

	[Address(RVA = "0x3A8350", Offset = "0x3A7550", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BF")]
	public void MouseMotionEvent(int x, int y) { }

	[Address(RVA = "0x3A83C0", Offset = "0x3A75C0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012BA")]
	public void OnPresent() { }

	[Address(RVA = "0x3A8410", Offset = "0x3A7610", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60012C8")]
	private static void OnToggleImpl(IntPtr ptr, bool locked) { }

	[Address(RVA = "0x3A8630", Offset = "0x3A7830", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B4")]
	public void OpenActivityInvite(ActivityActionType type, OpenActivityInviteHandler callback) { }

	[Address(RVA = "0x3A8530", Offset = "0x3A7730", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60012B3")]
	private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result) { }

	[Address(RVA = "0x3A88A0", Offset = "0x3A7AA0", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B6")]
	public void OpenGuildInvite(string code, OpenGuildInviteHandler callback) { }

	[Address(RVA = "0x3A87A0", Offset = "0x3A79A0", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60012B5")]
	private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result) { }

	[Address(RVA = "0x3A8B10", Offset = "0x3A7D10", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012B8")]
	public void OpenVoiceSettings(OpenVoiceSettingsHandler callback) { }

	[Address(RVA = "0x3A8A10", Offset = "0x3A7C10", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60012B7")]
	private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result) { }

	[Address(RVA = "0x3A9830", Offset = "0x3A8A30", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x60012AC")]
	public void remove_OnToggle(ToggleHandler value) { }

	[Address(RVA = "0x3A8DB0", Offset = "0x3A7FB0", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012C4")]
	public void SetImeCompositionRangeCallback(SetImeCompositionRangeCallbackHandler callback) { }

	[Address(RVA = "0x3A8C80", Offset = "0x3A7E80", Length = "0x12D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60012C3")]
	private static void SetImeCompositionRangeCallbackCallbackImpl(IntPtr ptr, int from, int to, ref Rect bounds) { }

	[Address(RVA = "0x3A9060", Offset = "0x3A8260", Length = "0x168")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012C6")]
	public void SetImeSelectionBoundsCallback(SetImeSelectionBoundsCallbackHandler callback) { }

	[Address(RVA = "0x3A8F10", Offset = "0x3A8110", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60012C5")]
	private static void SetImeSelectionBoundsCallbackCallbackImpl(IntPtr ptr, Rect anchor, Rect focus, bool isAnchorFirst) { }

	[Address(RVA = "0x3A92D0", Offset = "0x3A84D0", Length = "0x161")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(OverlayManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012B2")]
	public void SetLocked(bool locked, SetLockedHandler callback) { }

	[Address(RVA = "0x3A91D0", Offset = "0x3A83D0", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x60012B1")]
	private static void SetLockedCallbackImpl(IntPtr ptr, Result result) { }

}

