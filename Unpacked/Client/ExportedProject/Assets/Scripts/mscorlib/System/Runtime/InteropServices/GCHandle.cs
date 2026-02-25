namespace System.Runtime.InteropServices;

[ComVisible(True)]
[Token(Token = "0x200044D")]
public struct GCHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001224")]
	private IntPtr handle; //Field offset: 0x0

	[Token(Token = "0x170003ED")]
	public bool IsAllocated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001F9C")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170003EE")]
	public object Target
	{
		[Address(RVA = "0x13BA030", Offset = "0x13B9230", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gchandle_get_target")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001FA0")]
		 get { } //Length: 127
		[Address(RVA = "0x13BA0B0", Offset = "0x13B92B0", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CB10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001FA1")]
		 set { } //Length: 89
	}

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F99")]
	private GCHandle(IntPtr h) { }

	[Address(RVA = "0x13BA000", Offset = "0x13B9200", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CB10")]
	[Token(Token = "0x6001F9A")]
	private GCHandle(object obj) { }

	[Address(RVA = "0x13B9FD0", Offset = "0x13B91D0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CB10")]
	[Token(Token = "0x6001F9B")]
	internal GCHandle(object value, GCHandleType type) { }

	[Address(RVA = "0x13B9C50", Offset = "0x13B8E50", Length = "0xCD")]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "CopySafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", typeof(int), "T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char*", typeof(int), typeof(int), "System.UriComponents"}, ReturnType = typeof(string))]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "Unity.Collections.Allocator"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "ToArray", ReturnType = "T[]")]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "Unity.Collections.NativeArray`1<T>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<T>", "T[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Collections.NativeArray`1", Member = "CopySafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), "Unity.Collections.NativeArray`1<T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CA30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001FA2")]
	public IntPtr AddrOfPinnedObject() { }

	[Address(RVA = "0x13B9D20", Offset = "0x13B8F20", Length = "0x15")]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CB10")]
	[Token(Token = "0x6001FA4")]
	public static GCHandle Alloc(object value, GCHandleType type) { }

	[Address(RVA = "0x13B9D40", Offset = "0x13B8F40", Length = "0xF")]
	[CallerCount(Count = 73)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CB10")]
	[Token(Token = "0x6001FA3")]
	public static GCHandle Alloc(object value) { }

	[Address(RVA = "0x13B9D50", Offset = "0x13B8F50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001F9F")]
	internal static bool CanDereferenceHandle(IntPtr handle) { }

	[Address(RVA = "0x13B9D60", Offset = "0x13B8F60", Length = "0x5")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FA8")]
	private static bool CheckCurrentDomain(IntPtr handle) { }

	[Address(RVA = "0x13B9D70", Offset = "0x13B8F70", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001FAE")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x13B9E10", Offset = "0x13B9010", Length = "0x75")]
	[CallerCount(Count = 94)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gchandle_free")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FA5")]
	public void Free() { }

	[Address(RVA = "0x13B9E00", Offset = "0x13B9000", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gchandle_free")]
	[Token(Token = "0x6001FAB")]
	private static void FreeHandle(IntPtr handle) { }

	[Address(RVA = "0x13B9E90", Offset = "0x13B9090", Length = "0xB1")]
	[CallerCount(Count = 89)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FB0")]
	public static GCHandle FromIntPtr(IntPtr value) { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F9C")]
	public bool get_IsAllocated() { }

	[Address(RVA = "0x13BA030", Offset = "0x13B9230", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gchandle_get_target")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FA0")]
	public object get_Target() { }

	[Address(RVA = "0x13B9F50", Offset = "0x13B9150", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CA30")]
	[Token(Token = "0x6001FAC")]
	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	[Address(RVA = "0x12DD960", Offset = "0x12DCB60", Length = "0x7")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FAF")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x13B9F60", Offset = "0x13B9160", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F9D")]
	internal static object GetRef(IntPtr handle) { }

	[Address(RVA = "0x13B9F90", Offset = "0x13B9190", Length = "0x5")]
	[CallerCount(Count = 106)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_gchandle_get_target")]
	[Token(Token = "0x6001FA9")]
	private static object GetTarget(IntPtr handle) { }

	[Address(RVA = "0x13B9F80", Offset = "0x13B9180", Length = "0x5")]
	[CalledBy(Type = typeof(WeakReference), Member = "set_Target", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WeakReference`1), Member = "SetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GCHandlePool", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(GCHandle))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.GCHandlePool", Member = "ReturnAll", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.GCHandlePool", Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GCHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CB10")]
	[Token(Token = "0x6001FAA")]
	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	[Address(RVA = "0x2D8A50", Offset = "0x2D7C50", Length = "0x7")]
	[CallerCount(Count = 1453)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FAD")]
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FA6")]
	public static IntPtr op_Explicit(GCHandle value) { }

	[Address(RVA = "0x13B9E90", Offset = "0x13B9090", Length = "0xB1")]
	[CallerCount(Count = 89)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180083170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FA7")]
	public static GCHandle op_Explicit(IntPtr value) { }

	[Address(RVA = "0x13BA0B0", Offset = "0x13B92B0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020CB10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001FA1")]
	public void set_Target(object value) { }

	[Address(RVA = "0x13B9FA0", Offset = "0x13B91A0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001F9E")]
	internal static void SetRef(IntPtr handle, object value) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001FB1")]
	public static IntPtr ToIntPtr(GCHandle value) { }

}

