namespace Discord;

[Token(Token = "0x20001E4")]
public struct LobbyTransaction
{
	[Token(Token = "0x20001E5")]
	public struct FFIMethods
	{
		[Token(Token = "0x20001EA")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class DeleteMetadataMethod : MulticastDelegate
		{

			[Address(RVA = "0x391980", Offset = "0x390B80", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FCC")]
			public DeleteMetadataMethod(object object, IntPtr method) { }

			[Address(RVA = "0x38E2C0", Offset = "0x38D4C0", Length = "0x66")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FCE")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FCF")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FCD")]
			public override Result Invoke(IntPtr methodsPtr, string key) { }

		}

		[Token(Token = "0x20001E8")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetCapacityMethod : MulticastDelegate
		{

			[Address(RVA = "0x394140", Offset = "0x393340", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC4")]
			public SetCapacityMethod(object object, IntPtr method) { }

			[Address(RVA = "0x398B40", Offset = "0x397D40", Length = "0x6F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC6")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, uint capacity, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC7")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC5")]
			public override Result Invoke(IntPtr methodsPtr, uint capacity) { }

		}

		[Token(Token = "0x20001EB")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetLockedMethod : MulticastDelegate
		{

			[Address(RVA = "0x3A18F0", Offset = "0x3A0AF0", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FD0")]
			public SetLockedMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A1880", Offset = "0x3A0A80", Length = "0x6F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FD2")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, bool locked, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FD3")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FD1")]
			public override Result Invoke(IntPtr methodsPtr, bool locked) { }

		}

		[Token(Token = "0x20001E9")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetMetadataMethod : MulticastDelegate
		{

			[Address(RVA = "0x397000", Offset = "0x396200", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC8")]
			public SetMetadataMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A1B80", Offset = "0x3A0D80", Length = "0x6D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FCA")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, string value, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FCB")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x3354C0", Offset = "0x3346C0", Length = "0x14")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC9")]
			public override Result Invoke(IntPtr methodsPtr, string key, string value) { }

		}

		[Token(Token = "0x20001E7")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetOwnerMethod : MulticastDelegate
		{

			[Address(RVA = "0x391980", Offset = "0x390B80", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC0")]
			public SetOwnerMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3918E0", Offset = "0x390AE0", Length = "0x6F")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC2")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long ownerId, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC3")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FC1")]
			public override Result Invoke(IntPtr methodsPtr, long ownerId) { }

		}

		[Token(Token = "0x20001E6")]
		[UnmanagedFunctionPointer(CallingConvention::Winapi (1))]
		public sealed class SetTypeMethod : MulticastDelegate
		{

			[Address(RVA = "0x394140", Offset = "0x393340", Length = "0xA6")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FBC")]
			public SetTypeMethod(object object, IntPtr method) { }

			[Address(RVA = "0x3A1BF0", Offset = "0x3A0DF0", Length = "0x8B")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE3F0")]
			[Token(Token = "0x6000FBE")]
			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, LobbyType type, AsyncCallback callback, object object) { }

			[Address(RVA = "0x391950", Offset = "0x390B50", Length = "0x27")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE400")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FBF")]
			public override Result EndInvoke(IAsyncResult result) { }

			[Address(RVA = "0x335340", Offset = "0x334540", Length = "0xF")]
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000FBD")]
			public override Result Invoke(IntPtr methodsPtr, LobbyType type) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000711")]
		internal SetTypeMethod SetType; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000712")]
		internal SetOwnerMethod SetOwner; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000713")]
		internal SetCapacityMethod SetCapacity; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000714")]
		internal SetMetadataMethod SetMetadata; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000715")]
		internal DeleteMetadataMethod DeleteMetadata; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000716")]
		internal SetLockedMethod SetLocked; //Field offset: 0x28

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400070F")]
	internal IntPtr MethodsPtr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000710")]
	internal object MethodsStructure; //Field offset: 0x8

	[Token(Token = "0x170001DE")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x39F940", Offset = "0x39EB40", Length = "0x113")]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "DeleteMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(LobbyTransaction), Member = "SetLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Token(Token = "0x6000FB5")]
		private get { } //Length: 275
	}

	[Address(RVA = "0x39F560", Offset = "0x39E760", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FBA")]
	public void DeleteMetadata(string key) { }

	[Address(RVA = "0x39F940", Offset = "0x39EB40", Length = "0x113")]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LobbyType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "DeleteMetadata", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LobbyTransaction), Member = "SetLocked", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Marshal), Member = "PtrToStructure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6000FB5")]
	private FFIMethods get_Methods() { }

	[Address(RVA = "0x39F600", Offset = "0x39E800", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB8")]
	public void SetCapacity(uint capacity) { }

	[Address(RVA = "0x39F6A0", Offset = "0x39E8A0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FBB")]
	public void SetLocked(bool locked) { }

	[Address(RVA = "0x39F740", Offset = "0x39E940", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB9")]
	public void SetMetadata(string key, string value) { }

	[Address(RVA = "0x39F800", Offset = "0x39EA00", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB7")]
	public void SetOwner(long ownerId) { }

	[Address(RVA = "0x39F8A0", Offset = "0x39EAA0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LobbyTransaction), Member = "get_Methods", ReturnType = typeof(FFIMethods))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ResultException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Result)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000FB6")]
	public void SetType(LobbyType type) { }

}

