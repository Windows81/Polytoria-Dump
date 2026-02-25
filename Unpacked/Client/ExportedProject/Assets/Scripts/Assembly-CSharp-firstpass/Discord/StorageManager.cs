namespace Discord;

[Token(Token = "0x20002B8")]
public class StorageManager
{
	[Token(Token = "0x20002B9")]
	public struct FFIEvents
	{

	}

	[Token(Token = "0x20002BA")]
	public struct FFIMethods
	{
		[Token(Token = "0x20002C5")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class CountMethod : MulticastDelegate
		{

			[Address(RVA = "0x38E3F0", Offset = "0x38D5F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001387")]
			public CountMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391AC0", Offset = "0x390CC0", Length = "0x75")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001389")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, object object) { }

			[Address(RVA = "0x38E5D0", Offset = "0x38D7D0", Length = "0x1B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600138A")]
			public override void EndInvoke(ref int count, IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001388")]
			public override void Invoke(IntPtr methodsPtr, ref int count) { }

		}

		[Token(Token = "0x20002C3")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class DeleteMethod : MulticastDelegate
		{

			[Address(RVA = "0x391980", Offset = "0x390B80", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600137F")]
			public DeleteMethod(object object, IntPtr method) { }

			[Address(RVA = "0x38E2C0", Offset = "0x38D4C0", Length = "0x66")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001381")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001382")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001380")]
			public override Result Invoke(IntPtr methodsPtr, string name) { }

		}

		[Token(Token = "0x20002C4")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ExistsMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001383")]
			public ExistsMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A5100", Offset = "0x3A4300", Length = "0x7C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001385")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref bool exists, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001386")]
			public override Result EndInvoke(ref bool exists, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001384")]
			public override Result Invoke(IntPtr methodsPtr, string name, ref bool exists) { }

		}

		[Token(Token = "0x20002C8")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetPathMethod : MulticastDelegate
		{

			[Address(RVA = "0x391980", Offset = "0x390B80", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001393")]
			public GetPathMethod(object object, IntPtr method) { }

			[Address(RVA = "0x38E2C0", Offset = "0x38D4C0", Length = "0x66")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001395")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, StringBuilder path, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001396")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001394")]
			public override Result Invoke(IntPtr methodsPtr, StringBuilder path) { }

		}

		[Token(Token = "0x20002BC")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadAsyncCallback : MulticastDelegate
		{

			[Address(RVA = "0x3A9990", Offset = "0x3A8B90", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001363")]
			public ReadAsyncCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A98D0", Offset = "0x3A8AD0", Length = "0xBA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001365")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001366")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001364")]
			public override void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

		}

		[Token(Token = "0x20002BD")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadAsyncMethod : MulticastDelegate
		{

			[Address(RVA = "0x38DEF0", Offset = "0x38D0F0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001367")]
			public ReadAsyncMethod(object object, IntPtr method) { }

			[Address(RVA = "0x391850", Offset = "0x390A50", Length = "0x89")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001369")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600136A")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001368")]
			public override void Invoke(IntPtr methodsPtr, string name, IntPtr callbackData, ReadAsyncCallback callback) { }

		}

		[Token(Token = "0x20002BE")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadAsyncPartialCallback : MulticastDelegate
		{

			[Address(RVA = "0x3A9990", Offset = "0x3A8B90", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600136B")]
			public ReadAsyncPartialCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3A9AD0", Offset = "0x3A8CD0", Length = "0xBA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600136D")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600136E")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600136C")]
			public override void Invoke(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

		}

		[Token(Token = "0x20002BF")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadAsyncPartialMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A3170", Offset = "0x3A2370", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600136F")]
			public ReadAsyncPartialMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A9C20", Offset = "0x3A8E20", Length = "0xBE")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001371")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001372")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3359C0", Offset = "0x334BC0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001370")]
			public override void Invoke(IntPtr methodsPtr, string name, ulong offset, ulong length, IntPtr callbackData, ReadAsyncPartialCallback callback) { }

		}

		[Token(Token = "0x20002BB")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class ReadMethod : MulticastDelegate
		{

			[Address(RVA = "0x397640", Offset = "0x396840", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600135F")]
			public ReadMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A9CE0", Offset = "0x3A8EE0", Length = "0xA5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001361")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, ref uint read, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001362")]
			public override Result EndInvoke(ref uint read, IAsyncResult result) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001360")]
			public override Result Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, ref uint read) { }

		}

		[Token(Token = "0x20002C7")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class StatAtMethod : MulticastDelegate
		{

			[Address(RVA = "0x391E10", Offset = "0x391010", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600138F")]
			public StatAtMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3AB070", Offset = "0x3AA270", Length = "0xA1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001391")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref FileStat stat, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001392")]
			public override Result EndInvoke(ref FileStat stat, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001390")]
			public override Result Invoke(IntPtr methodsPtr, int index, ref FileStat stat) { }

		}

		[Token(Token = "0x20002C6")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class StatMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600138B")]
			public StatMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3AB120", Offset = "0x3AA320", Length = "0x98")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600138D")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, ref FileStat stat, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x600138E")]
			public override Result EndInvoke(ref FileStat stat, IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600138C")]
			public override Result Invoke(IntPtr methodsPtr, string name, ref FileStat stat) { }

		}

		[Token(Token = "0x20002C1")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class WriteAsyncCallback : MulticastDelegate
		{

			[Address(RVA = "0x38DC70", Offset = "0x38CE70", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001377")]
			public WriteAsyncCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3AF1C0", Offset = "0x3AE3C0", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001379")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600137A")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001378")]
			public override void Invoke(IntPtr ptr, Result result) { }

		}

		[Token(Token = "0x20002C2")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class WriteAsyncMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A13C0", Offset = "0x3A05C0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x600137B")]
			public WriteAsyncMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3AF2D0", Offset = "0x3AE4D0", Length = "0xB5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x600137D")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x600137E")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3359C0", Offset = "0x334BC0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600137C")]
			public override void Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, IntPtr callbackData, WriteAsyncCallback callback) { }

		}

		[Token(Token = "0x20002C0")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class WriteMethod : MulticastDelegate
		{

			[Address(RVA = "0x3AF420", Offset = "0x3AE620", Length = "0x3AC")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = "PurchasesService+<ShowPurchaseModal>d__13", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[Calls(Type = "PurchasesService+<DoProcessPurchase>d__18", Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6001373")]
			public WriteMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3AF390", Offset = "0x3AE590", Length = "0x8C")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6001375")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6001376")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001374")]
			public override Result Invoke(IntPtr methodsPtr, string name, Byte[] data, int dataLen) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40007EF")]
		internal ReadMethod Read; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40007F0")]
		internal ReadAsyncMethod ReadAsync; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40007F1")]
		internal ReadAsyncPartialMethod ReadAsyncPartial; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40007F2")]
		internal WriteMethod Write; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40007F3")]
		internal WriteAsyncMethod WriteAsync; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40007F4")]
		internal DeleteMethod Delete; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40007F5")]
		internal ExistsMethod Exists; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40007F6")]
		internal CountMethod Count; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40007F7")]
		internal StatMethod Stat; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40007F8")]
		internal StatAtMethod StatAt; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40007F9")]
		internal GetPathMethod GetPath; //Field offset: 0x50

	}

	[Token(Token = "0x20002C9")]
	internal sealed class ReadAsyncHandler : MulticastDelegate
	{

		[Address(RVA = "0x3914F0", Offset = "0x3906F0", Length = "0xA6")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001397")]
		public ReadAsyncHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A9A40", Offset = "0x3A8C40", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x6001399")]
		public override IAsyncResult BeginInvoke(Result result, Byte[] data, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600139A")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001398")]
		public override void Invoke(Result result, Byte[] data) { }

	}

	[Token(Token = "0x20002CA")]
	internal sealed class ReadAsyncPartialHandler : MulticastDelegate
	{

		[Address(RVA = "0x3914F0", Offset = "0x3906F0", Length = "0xA6")]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600139B")]
		public ReadAsyncPartialHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3A9B90", Offset = "0x3A8D90", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x600139D")]
		public override IAsyncResult BeginInvoke(Result result, Byte[] data, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x600139E")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600139C")]
		public override void Invoke(Result result, Byte[] data) { }

	}

	[Token(Token = "0x20002CB")]
	internal sealed class WriteAsyncHandler : MulticastDelegate
	{

		[Address(RVA = "0x38DDA0", Offset = "0x38CFA0", Length = "0xA6")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[DeduplicatedMethod]
		[Token(Token = "0x600139F")]
		public WriteAsyncHandler(object object, IntPtr method) { }

		[Address(RVA = "0x3AF250", Offset = "0x3AE450", Length = "0x7A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x60013A1")]
		public override IAsyncResult BeginInvoke(Result result, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x60013A2")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013A0")]
		public override void Invoke(Result result) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007ED")]
	private IntPtr MethodsPtr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007EE")]
	private object MethodsStructure; //Field offset: 0x18

	[Token(Token = "0x170001E9")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x3AC420", Offset = "0x3AB620", Length = "0x12E")]
		[CalledBy(Type = typeof(StorageManager), Member = "StatAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FileStat))]
		[CalledBy(Type = typeof(StorageManager), Member = "Files", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Discord.FileStat>))]
		[CalledBy(Type = typeof(StorageManager), Member = "GetPath", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(StorageManager), Member = "Stat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStat))]
		[CalledBy(Type = typeof(StorageManager), Member = "Count", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(StorageManager), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(StorageManager), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "ReadAsyncPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong), typeof(ulong), typeof(ReadAsyncPartialHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ReadAsyncHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StorageManager), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(uint))]
		[CalledBy(Type = typeof(StorageManager), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(WriteAsyncHandler)}, ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x600134D")]
		private get { } //Length: 302
	}

	[Address(RVA = "0x3AC300", Offset = "0x3AB500", Length = "0x112")]
	[CalledBy(Type = typeof(Discord), Member = "GetStorageManager", ReturnType = typeof(StorageManager))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600134E")]
	internal StorageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3AB1C0", Offset = "0x3AA3C0", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600135A")]
	public int Count() { }

	[Address(RVA = "0x3AB220", Offset = "0x3AA420", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001358")]
	public void Delete(string name) { }

	[Address(RVA = "0x3AB2C0", Offset = "0x3AA4C0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001359")]
	public bool Exists(string name) { }

	[Address(RVA = "0x3AB380", Offset = "0x3AA580", Length = "0x243")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600135E")]
	public IEnumerable<FileStat> Files() { }

	[Address(RVA = "0x3AC420", Offset = "0x3AB620", Length = "0x12E")]
	[CalledBy(Type = typeof(StorageManager), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[]), typeof(WriteAsyncHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ReadAsyncHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "ReadAsyncPartial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ulong), typeof(ulong), typeof(ReadAsyncPartialHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StorageManager), Member = "Exists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StorageManager), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Byte[])}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(StorageManager), Member = "Count", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StorageManager), Member = "Stat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FileStat))]
	[CalledBy(Type = typeof(StorageManager), Member = "GetPath", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StorageManager), Member = "Files", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<Discord.FileStat>))]
	[CalledBy(Type = typeof(StorageManager), Member = "StatAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(FileStat))]
	[CalledBy(Type = typeof(StorageManager), Member = "Delete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600134D")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x3AB5D0", Offset = "0x3AA7D0", Length = "0xFB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600135D")]
	public string GetPath() { }

	[Address(RVA = "0x3AB6D0", Offset = "0x3AA8D0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600134F")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3ABD30", Offset = "0x3AAF30", Length = "0xD9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001350")]
	public uint Read(string name, Byte[] data) { }

	[Address(RVA = "0x3ABBC0", Offset = "0x3AADC0", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001352")]
	public void ReadAsync(string name, ReadAsyncHandler callback) { }

	[Address(RVA = "0x3AB740", Offset = "0x3AA940", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x6001351")]
	private static void ReadAsyncCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	[Address(RVA = "0x3ABA40", Offset = "0x3AAC40", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001354")]
	public void ReadAsyncPartial(string name, ulong offset, ulong length, ReadAsyncPartialHandler callback) { }

	[Address(RVA = "0x3AB8C0", Offset = "0x3AAAC0", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[MonoPInvokeCallback]
	[Token(Token = "0x6001353")]
	private static void ReadAsyncPartialCallbackImpl(IntPtr ptr, Result result, IntPtr dataPtr, int dataLen) { }

	[Address(RVA = "0x3ABED0", Offset = "0x3AB0D0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600135B")]
	public FileStat Stat(string name) { }

	[Address(RVA = "0x3ABE10", Offset = "0x3AB010", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600135C")]
	public FileStat StatAt(int index) { }

	[Address(RVA = "0x3AC230", Offset = "0x3AB430", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001355")]
	public void Write(string name, Byte[] data) { }

	[Address(RVA = "0x3AC090", Offset = "0x3AB290", Length = "0x193")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(StorageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001357")]
	public void WriteAsync(string name, Byte[] data, WriteAsyncHandler callback) { }

	[Address(RVA = "0x3ABF90", Offset = "0x3AB190", Length = "0xFF")]
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
	[Token(Token = "0x6001356")]
	private static void WriteAsyncCallbackImpl(IntPtr ptr, Result result) { }

}

