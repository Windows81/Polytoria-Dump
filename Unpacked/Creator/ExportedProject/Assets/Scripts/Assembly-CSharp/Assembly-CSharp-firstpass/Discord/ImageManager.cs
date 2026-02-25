namespace Discord;

[Token(Token = "0x2000226")]
public class ImageManager
{
	[Token(Token = "0x200022D")]
	internal sealed class FetchHandler : MulticastDelegate
	{

		[Address(RVA = "0x394470", Offset = "0x393670", Length = "0xA6")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60010CA")]
		public FetchHandler(object object, IntPtr method) { }

		[Address(RVA = "0x394390", Offset = "0x393590", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
		[Token(Token = "0x60010CC")]
		public override IAsyncResult BeginInvoke(Result result, ImageHandle handleResult, AsyncCallback callback, object object) { }

		[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CD")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x394430", Offset = "0x393630", Length = "0x31")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010CB")]
		public override void Invoke(Result result, ImageHandle handleResult) { }

	}

	[Token(Token = "0x2000227")]
	public struct FFIEvents
	{

	}

	[Token(Token = "0x2000228")]
	public struct FFIMethods
	{
		[Token(Token = "0x2000229")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchCallback : MulticastDelegate
		{

			[Address(RVA = "0x3942E0", Offset = "0x3934E0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x60010BA")]
			public FetchCallback(object object, IntPtr method) { }

			[Address(RVA = "0x3941F0", Offset = "0x3933F0", Length = "0xAD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60010BC")]
			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ImageHandle handleResult, AsyncCallback callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60010BD")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3942A0", Offset = "0x3934A0", Length = "0x37")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x60010BB")]
			public override void Invoke(IntPtr ptr, Result result, ImageHandle handleResult) { }

		}

		[Token(Token = "0x200022A")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FetchMethod : MulticastDelegate
		{

			[Address(RVA = "0x394650", Offset = "0x393850", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x60010BE")]
			public FetchMethod(object object, IntPtr method) { }

			[Address(RVA = "0x394520", Offset = "0x393720", Length = "0xCD")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60010C0")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback, AsyncCallback __callback, object object) { }

			[Address(RVA = "0x2D8800", Offset = "0x2D7A00", Length = "0xA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[DeduplicatedMethod]
			[Token(Token = "0x60010C1")]
			public override void EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3945F0", Offset = "0x3937F0", Length = "0x51")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010BF")]
			public override void Invoke(IntPtr methodsPtr, ImageHandle handle, bool refresh, IntPtr callbackData, FetchCallback callback) { }

		}

		[Token(Token = "0x200022C")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetDataMethod : MulticastDelegate
		{

			[Address(RVA = "0x396D20", Offset = "0x395F20", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x60010C6")]
			public GetDataMethod(object object, IntPtr method) { }

			[Address(RVA = "0x396C10", Offset = "0x395E10", Length = "0xB7")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60010C8")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, Byte[] data, int dataLen, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60010C9")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x396CD0", Offset = "0x395ED0", Length = "0x42")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x60010C7")]
			public override Result Invoke(IntPtr methodsPtr, ImageHandle handle, Byte[] data, int dataLen) { }

		}

		[Token(Token = "0x200022B")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class GetDimensionsMethod : MulticastDelegate
		{

			[Address(RVA = "0x396ED0", Offset = "0x3960D0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x60010C2")]
			public GetDimensionsMethod(object object, IntPtr method) { }

			[Address(RVA = "0x396DD0", Offset = "0x395FD0", Length = "0xB3")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x60010C4")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391B40", Offset = "0x390D40", Length = "0x2F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x60010C5")]
			public override Result EndInvoke(ref ImageDimensions dimensions, IAsyncResult result) { }

			[Address(RVA = "0x396E90", Offset = "0x396090", Length = "0x37")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x60010C3")]
			public override Result Invoke(IntPtr methodsPtr, ImageHandle handle, ref ImageDimensions dimensions) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000788")]
		internal FetchMethod Fetch; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000789")]
		internal GetDimensionsMethod GetDimensions; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400078A")]
		internal GetDataMethod GetData; //Field offset: 0x10

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000786")]
	private IntPtr MethodsPtr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000787")]
	private object MethodsStructure; //Field offset: 0x18

	[Token(Token = "0x170001E4")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x398A30", Offset = "0x397C30", Length = "0x10E")]
		[CalledBy(Type = typeof(ImageManager), Member = "Fetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(bool), typeof(FetchHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ImageManager), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(ImageDimensions))]
		[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(Byte[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ImageManager), Member = "Fetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(FetchHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(ImageManager), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Texture2D))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x60010B0")]
		private get { } //Length: 270
	}

	[Address(RVA = "0x398910", Offset = "0x397B10", Length = "0x112")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60010B1")]
	internal ImageManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[Address(RVA = "0x3981F0", Offset = "0x3973F0", Length = "0x1A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010B4")]
	public void Fetch(ImageHandle handle, bool refresh, FetchHandler callback) { }

	[Address(RVA = "0x398050", Offset = "0x397250", Length = "0x196")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010B7")]
	public void Fetch(ImageHandle handle, FetchHandler callback) { }

	[Address(RVA = "0x397F20", Offset = "0x397120", Length = "0x12C")]
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
	[Token(Token = "0x60010B3")]
	private static void FetchCallbackImpl(IntPtr ptr, Result result, ImageHandle handleResult) { }

	[Address(RVA = "0x398A30", Offset = "0x397C30", Length = "0x10E")]
	[CalledBy(Type = typeof(ImageManager), Member = "Fetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(bool), typeof(FetchHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(ImageDimensions))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ImageManager), Member = "Fetch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle), typeof(FetchHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60010B0")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x3984E0", Offset = "0x3976E0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010B6")]
	public void GetData(ImageHandle handle, Byte[] data) { }

	[Address(RVA = "0x3983A0", Offset = "0x3975A0", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ImageManager), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(ImageDimensions))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010B8")]
	public Byte[] GetData(ImageHandle handle) { }

	[Address(RVA = "0x3985D0", Offset = "0x3977D0", Length = "0xD5")]
	[CalledBy(Type = typeof(ImageManager), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(ImageManager), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(Texture2D))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010B5")]
	public ImageDimensions GetDimensions(ImageHandle handle) { }

	[Address(RVA = "0x3986B0", Offset = "0x3978B0", Length = "0x1EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ImageManager), Member = "GetDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ImageHandle)}, ReturnType = typeof(ImageDimensions))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(ImageManager), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(Texture2D), Member = "LoadRawTextureData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010B9")]
	public Texture2D GetTexture(ImageHandle handle) { }

	[Address(RVA = "0x3988A0", Offset = "0x397AA0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "StructureToPtr", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010B2")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

}

