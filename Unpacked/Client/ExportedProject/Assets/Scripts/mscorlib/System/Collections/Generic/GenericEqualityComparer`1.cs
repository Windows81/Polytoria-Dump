namespace System.Collections.Generic;

[Token(Token = "0x20005FF")]
internal class GenericEqualityComparer : EqualityComparer<T>
{

	[Address(RVA = "0xC51070", Offset = "0xC50270", Length = "0x334")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[Calls(Type = "UnityEngine.Matrix4x4", Member = "GetColumn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.Vector4")]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C12")]
	public GenericEqualityComparer`1() { }

	[Address(RVA = "0xC4AE40", Offset = "0xC4A040", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C0C")]
	public virtual bool Equals(T x, T y) { }

	[Address(RVA = "0xC4A9D0", Offset = "0xC49BD0", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C10")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xC4BB70", Offset = "0xC4AD70", Length = "0x20")]
	[CallerCount(Count = 0)]
	[Calls(Type = "Unity.Collections.NativeArray`1", Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C0D")]
	public virtual int GetHashCode(T obj) { }

	[Address(RVA = "0xAE1270", Offset = "0xAE0470", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C11")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xC4CBB0", Offset = "0xC4BDB0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C0E")]
	internal virtual int IndexOf(T[] array, T value, int startIndex, int count) { }

	[Address(RVA = "0xC4FD80", Offset = "0xC4EF80", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002C0F")]
	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count) { }

}

