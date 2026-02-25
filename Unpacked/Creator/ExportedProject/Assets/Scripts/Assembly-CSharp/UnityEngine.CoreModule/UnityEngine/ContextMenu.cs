namespace UnityEngine;

[AttributeUsage(AttributeTargets::Method (64), AllowMultiple = True)]
[RequiredByNativeCode]
[Token(Token = "0x2000126")]
public sealed class ContextMenu : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400051A")]
	public readonly string menuItem; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400051B")]
	public readonly bool validate; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400051C")]
	public readonly int priority; //Field offset: 0x1C

	[Address(RVA = "0x195EFB0", Offset = "0x195E1B0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008DD")]
	public ContextMenu(string itemName) { }

	[Address(RVA = "0x195EF60", Offset = "0x195E160", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008DE")]
	public ContextMenu(string itemName, bool isValidateFunction) { }

	[Address(RVA = "0x195EF00", Offset = "0x195E100", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60008DF")]
	public ContextMenu(string itemName, bool isValidateFunction, int priority) { }

}

