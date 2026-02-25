namespace System.Security;

[ComVisible(True)]
[Token(Token = "0x20002C6")]
public class SecurityException : SystemException
{
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000C24")]
	private string permissionState; //Field offset: 0x90

	[Address(RVA = "0x1332470", Offset = "0x1331670", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600171B")]
	public SecurityException() { }

	[Address(RVA = "0x1332450", Offset = "0x1331650", Length = "0x1E")]
	[CalledBy(Type = typeof(ThrowHelper), Member = "ThrowSecurityException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsIdentity), Member = "Impersonate", ReturnType = typeof(WindowsImpersonationContext))]
	[CalledBy(Type = typeof(WindowsImpersonationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsImpersonationContext), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WindowsImpersonationContext), Member = "Undo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(ObjectWriter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ISurrogateSelector), typeof(StreamingContext), typeof(SerObjectInfoInit), typeof(IFormatterConverter), typeof(SerializationBinder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WriteObjectInfo), Member = "CheckTypeForwardedFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerObjectInfoCache), typeof(Type), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(AssemblyName), Member = "InternalGetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600171C")]
	public SecurityException(string message) { }

	[Address(RVA = "0x13324C0", Offset = "0x13316C0", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
	[Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600171D")]
	protected SecurityException(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x13323B0", Offset = "0x13315B0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "GetObjectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600171E")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1332440", Offset = "0x1331640", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Exception), Member = "ToString", ReturnType = typeof(string))]
	[Token(Token = "0x600171F")]
	public virtual string ToString() { }

}

