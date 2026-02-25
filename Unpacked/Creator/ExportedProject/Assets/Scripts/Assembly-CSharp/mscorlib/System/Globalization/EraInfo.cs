namespace System.Globalization;

[Token(Token = "0x2000556")]
internal class EraInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001664")]
	internal int era; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001665")]
	internal long ticks; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001666")]
	internal int yearOffset; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001667")]
	internal int minEraYear; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001668")]
	internal int maxEraYear; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x4001669")]
	internal string eraName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x400166A")]
	internal string abbrevEraName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[OptionalField(VersionAdded = 4)]
	[Token(Token = "0x400166B")]
	internal string englishEraName; //Field offset: 0x40

	[Address(RVA = "0x13F2470", Offset = "0x13F1670", Length = "0xC7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600268A")]
	internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	[Address(RVA = "0x13F2360", Offset = "0x13F1560", Length = "0x106")]
	[CalledBy(Type = typeof(JapaneseCalendar), Member = "GetEraInfo", ReturnType = typeof(EraInfo[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Ticks", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600268B")]
	internal EraInfo(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

