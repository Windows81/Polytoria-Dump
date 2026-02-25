namespace Discord;

[Token(Token = "0x20001F0")]
public struct LobbySearchQuery
{
	[Token(Token = "0x20001F1")]
	public struct FFIMethods
	{
		[Token(Token = "0x20001F5")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class DistanceMethod : MulticastDelegate
		{

			[Address(RVA = "0x394140", Offset = "0x393340", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FF0")]
			public DistanceMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3940B0", Offset = "0x3932B0", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6000FF2")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbySearchDistance distance, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FF3")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FF1")]
			public override Result Invoke(IntPtr methodsPtr, LobbySearchDistance distance) { }

		}

		[Token(Token = "0x20001F2")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class FilterMethod : MulticastDelegate
		{

			[Address(RVA = "0x395DF0", Offset = "0x394FF0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000FE4")]
			public FilterMethod(object object, IntPtr method) { }

			[Address(RVA = "0x395D20", Offset = "0x394F20", Length = "0xCA")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6000FE6")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FE7")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FE5")]
			public override Result Invoke(IntPtr methodsPtr, string key, LobbySearchComparison comparison, LobbySearchCast cast, string value) { }

		}

		[Token(Token = "0x20001F4")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class LimitMethod : MulticastDelegate
		{

			[Address(RVA = "0x394140", Offset = "0x393340", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FEC")]
			public LimitMethod(object object, IntPtr method) { }

			[Address(RVA = "0x398B40", Offset = "0x397D40", Length = "0x6F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FEE")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, uint limit, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FEF")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FED")]
			public override Result Invoke(IntPtr methodsPtr, uint limit) { }

		}

		[Token(Token = "0x20001F3")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SortMethod : MulticastDelegate
		{

			[Address(RVA = "0x397260", Offset = "0x396460", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FE8")]
			public SortMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A1C80", Offset = "0x3A0E80", Length = "0xA5")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6000FEA")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, LobbySearchCast cast, string value, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FEB")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FE9")]
			public override Result Invoke(IntPtr methodsPtr, string key, LobbySearchCast cast, string value) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400071D")]
		internal FilterMethod Filter; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400071E")]
		internal SortMethod Sort; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400071F")]
		internal LimitMethod Limit; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000720")]
		internal DistanceMethod Distance; //Field offset: 0x18

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400071B")]
	internal IntPtr MethodsPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400071C")]
	internal object MethodsStructure; //Field offset: 0x8

	[Token(Token = "0x170001E0")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x39F450", Offset = "0x39E650", Length = "0x10B")]
		[CalledBy(Type = typeof(LobbySearchQuery), Member = "Filter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LobbySearchComparison), typeof(LobbySearchCast), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbySearchQuery), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LobbySearchCast), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbySearchQuery), Member = "Limit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbySearchQuery), Member = "Distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbySearchDistance)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x6000FDF")]
		private get { } //Length: 267
	}

	[Address(RVA = "0x39F170", Offset = "0x39E370", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchQuery), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FE3")]
	public void Distance(LobbySearchDistance distance) { }

	[Address(RVA = "0x39F210", Offset = "0x39E410", Length = "0xD3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchQuery), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FE0")]
	public void Filter(string key, LobbySearchComparison comparison, LobbySearchCast cast, string value) { }

	[Address(RVA = "0x39F450", Offset = "0x39E650", Length = "0x10B")]
	[CalledBy(Type = typeof(LobbySearchQuery), Member = "Filter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LobbySearchComparison), typeof(LobbySearchCast), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbySearchQuery), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LobbySearchCast), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbySearchQuery), Member = "Limit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbySearchQuery), Member = "Distance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbySearchDistance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000FDF")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x39F2F0", Offset = "0x39E4F0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchQuery), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FE2")]
	public void Limit(uint limit) { }

	[Address(RVA = "0x39F390", Offset = "0x39E590", Length = "0xBE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbySearchQuery), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FE1")]
	public void Sort(string key, LobbySearchCast cast, string value) { }

}

