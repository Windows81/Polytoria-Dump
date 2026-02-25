namespace UnityEngine.TextCore;

[Token(Token = "0x200000D")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class RichTextTagParser
{
	[Nullable(0)]
	[NullableContext(1)]
	[Token(Token = "0x2000015")]
	public class ParseError : IEquatable<ParseError>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000072")]
		public readonly int position; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000073")]
		public readonly string message; //Field offset: 0x18

		[CompilerGenerated]
		[Token(Token = "0x17000007")]
		protected override Type EqualityContract
		{
			[Address(RVA = "0x1A36D40", Offset = "0x1A35F40", Length = "0x4D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[CompilerGenerated]
			[Token(Token = "0x6000029")]
			 get { } //Length: 77
		}

		[Address(RVA = "0x1A36CF0", Offset = "0x1A35EF0", Length = "0x42")]
		[CalledBy(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600002A")]
		internal ParseError(string message, int position) { }

		[Address(RVA = "0x1A36850", Offset = "0x1A35A50", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x600002E")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x1A368E0", Offset = "0x1A35AE0", Length = "0x156")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		[NullableContext(2)]
		[Token(Token = "0x600002F")]
		public override bool Equals(ParseError other) { }

		[Address(RVA = "0x1A36D40", Offset = "0x1A35F40", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CompilerGenerated]
		[Token(Token = "0x6000029")]
		protected override Type get_EqualityContract() { }

		[Address(RVA = "0x1A36A40", Offset = "0x1A35C40", Length = "0x10F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023D30")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 4)]
		[CompilerGenerated]
		[Token(Token = "0x600002D")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1A36B50", Offset = "0x1A35D50", Length = "0xA2")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RuntimeHelpers), Member = "EnsureSufficientExecutionStack", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CompilerGenerated]
		[Token(Token = "0x600002C")]
		protected override bool PrintMembers(StringBuilder builder) { }

		[Address(RVA = "0x1A36C00", Offset = "0x1A35E00", Length = "0xEA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[Token(Token = "0x600002B")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000014")]
	internal struct Segment
	{
		[FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		[Token(Token = "0x400006F")]
		public List<Tag> tags; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000070")]
		public int start; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000071")]
		public int end; //Field offset: 0xC

	}

	[Token(Token = "0x2000013")]
	public struct Tag
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		public TagType tagType; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400006B")]
		public bool isClosing; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400006C")]
		public int start; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400006D")]
		public int end; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Nullable(2)]
		[Token(Token = "0x400006E")]
		public TagValue value; //Field offset: 0x10

	}

	[Token(Token = "0x200000E")]
	internal enum TagType
	{
		Hyperlink = 0,
		Align = 1,
		AllCaps = 2,
		Alpha = 3,
		Bold = 4,
		Br = 5,
		Color = 6,
		CSpace = 7,
		Font = 8,
		FontWeight = 9,
		Italic = 10,
		Indent = 11,
		LineHeight = 12,
		LineIndent = 13,
		Link = 14,
		Lowercase = 15,
		Mark = 16,
		Mspace = 17,
		NoBr = 18,
		NoParse = 19,
		Strikethrough = 20,
		Size = 21,
		SmallCaps = 22,
		Space = 23,
		Sprite = 24,
		Style = 25,
		Subscript = 26,
		Superscript = 27,
		Underline = 28,
		Uppercase = 29,
		Unknown = 30,
	}

	[Nullable(0)]
	[NullableContext(1)]
	[Token(Token = "0x200000F")]
	public class TagTypeInfo : IEquatable<TagTypeInfo>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000059")]
		public TagType TagType; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400005A")]
		public string name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400005B")]
		public TagValueType valueType; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400005C")]
		public TagUnitType unitType; //Field offset: 0x24

		[CompilerGenerated]
		[Token(Token = "0x17000003")]
		protected override Type EqualityContract
		{
			[Address(RVA = "0x1A3AE70", Offset = "0x1A3A070", Length = "0x4D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[CompilerGenerated]
			[Token(Token = "0x6000018")]
			 get { } //Length: 77
		}

		[Address(RVA = "0x1A3AE10", Offset = "0x1A3A010", Length = "0x58")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000019")]
		internal TagTypeInfo(TagType tagType, string name, TagValueType valueType = 0, TagUnitType unitType = 0) { }

		[Address(RVA = "0x1A3A740", Offset = "0x1A39940", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x600001D")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x1A3A7D0", Offset = "0x1A399D0", Length = "0x1E4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>))]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		[NullableContext(2)]
		[Token(Token = "0x600001E")]
		public override bool Equals(TagTypeInfo other) { }

		[Address(RVA = "0x1A3AE70", Offset = "0x1A3A070", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CompilerGenerated]
		[Token(Token = "0x6000018")]
		protected override Type get_EqualityContract() { }

		[Address(RVA = "0x1A3A9C0", Offset = "0x1A39BC0", Length = "0x1B3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[CompilerGenerated]
		[Token(Token = "0x600001C")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x1A3AB80", Offset = "0x1A39D80", Length = "0x192")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(RuntimeHelpers), Member = "EnsureSufficientExecutionStack", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CompilerGenerated]
		[Token(Token = "0x600001B")]
		protected override bool PrintMembers(StringBuilder builder) { }

		[Address(RVA = "0x1A3AD20", Offset = "0x1A39F20", Length = "0xEA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[Token(Token = "0x600001A")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000011")]
	public enum TagUnitType
	{
		Pixels = 0,
		FontUnits = 1,
		Percentage = 2,
	}

	[Nullable(0)]
	[NullableContext(2)]
	[Token(Token = "0x2000012")]
	public class TagValue : IEquatable<TagValue>
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000066")]
		internal TagValueType type; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000067")]
		private string m_stringValue; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000068")]
		private float m_numericalValue; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000069")]
		private Color m_colorValue; //Field offset: 0x24

		[Token(Token = "0x17000006")]
		internal Color ColorValue
		{
			[Address(RVA = "0x1A3B480", Offset = "0x1A3A680", Length = "0x71")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000023")]
			internal get { } //Length: 113
		}

		[CompilerGenerated]
		[Nullable(1)]
		[Token(Token = "0x17000004")]
		protected override Type EqualityContract
		{
			[Address(RVA = "0x1A3B500", Offset = "0x1A3A700", Length = "0x4D")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
			[CompilerGenerated]
			[NullableContext(1)]
			[Token(Token = "0x600001F")]
			 get { } //Length: 77
		}

		[Token(Token = "0x17000005")]
		internal string StringValue
		{
			[Address(RVA = "0x1A3B550", Offset = "0x1A3A750", Length = "0x65")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x6000022")]
			internal get { } //Length: 101
		}

		[Address(RVA = "0x1A3B450", Offset = "0x1A3A650", Length = "0x30")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000020")]
		internal TagValue(Color value) { }

		[Address(RVA = "0x1A3B410", Offset = "0x1A3A610", Length = "0x38")]
		[CalledBy(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[NullableContext(1)]
		[Token(Token = "0x6000021")]
		internal TagValue(string value) { }

		[Address(RVA = "0x1A3B0D0", Offset = "0x1A3A2D0", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[Token(Token = "0x6000027")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x1A3AEC0", Offset = "0x1A3A0C0", Length = "0x203")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>))]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180026F70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023A00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		[CompilerGenerated]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000028")]
		public override bool Equals(TagValue other) { }

		[Address(RVA = "0x1A3B480", Offset = "0x1A3A680", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000023")]
		internal Color get_ColorValue() { }

		[Address(RVA = "0x1A3B500", Offset = "0x1A3A700", Length = "0x4D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CompilerGenerated]
		[NullableContext(1)]
		[Token(Token = "0x600001F")]
		protected override Type get_EqualityContract() { }

		[Address(RVA = "0x1A3B550", Offset = "0x1A3A750", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x6000022")]
		internal string get_StringValue() { }

		[Address(RVA = "0x1A3B160", Offset = "0x1A3A360", Length = "0x1BF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Object>))]
		[Calls(Type = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>), Member = "get_Default", ReturnType = typeof(System.Collections.Generic.EqualityComparer`1<System.Int32Enum>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180026F70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180023A00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 6)]
		[CompilerGenerated]
		[Token(Token = "0x6000026")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(1)]
		[Token(Token = "0x6000025")]
		protected override bool PrintMembers(StringBuilder builder) { }

		[Address(RVA = "0x1A3B320", Offset = "0x1A3A520", Length = "0xEA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[NullableContext(1)]
		[Token(Token = "0x6000024")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000010")]
	public enum TagValueType
	{
		None = 0,
		NumericalValue = 1,
		StringValue = 2,
		ColorValue = 4,
	}

	[Nullable(1)]
	[Token(Token = "0x4000038")]
	internal static readonly TagTypeInfo[] TagsInfo; //Field offset: 0x0

	[Address(RVA = "0x1A394C0", Offset = "0x1A386C0", Length = "0x112A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 30)]
	[Token(Token = "0x6000017")]
	private static RichTextTagParser() { }

	[Address(RVA = "0x1A36D90", Offset = "0x1A35F90", Length = "0x242")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ValueTuple`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2", "T3"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[NullableContext(1)]
	[Token(Token = "0x6000014")]
	private static int AddLink(TagType type, string value, List<ValueTuple`3<Int32, TagType, String>> links) { }

	[Address(RVA = "0x1A36FE0", Offset = "0x1A361E0", Length = "0xEF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RichTextTagParser), Member = "PickResultingTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>), typeof(string), typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[NullableContext(1)]
	[Token(Token = "0x6000013")]
	internal static void ApplyStateToSegment(string input, List<Tag> tags, Segment[] segments) { }

	[Address(RVA = "0x1A370D0", Offset = "0x1A362D0", Length = "0x398")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeNativeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "UpdateNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "System.ValueTuple`2<NativeTextInfo, Boolean>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RichTextTagParser), Member = "GenerateSegments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>)}, ReturnType = typeof(Segment[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RichTextTagParser), Member = "PickResultingTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>), typeof(string), typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[Calls(Type = typeof(RichTextTagParser), Member = "CreateTextSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Segment), typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(TextSpan))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000016")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void CreateTextGenerationSettingsArray(ref NativeTextGenerationSettings tgs, List<ValueTuple`3<Int32, TagType, String>> links, Color hyperlinkColor) { }

	[Address(RVA = "0x1A37470", Offset = "0x1A36670", Length = "0x124")]
	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6000015")]
	private static TextSpan CreateTextSpan(Segment segment, ref NativeTextGenerationSettings tgs, List<ValueTuple`3<Int32, TagType, String>> links, Color hyperlinkColor) { }

	[Address(RVA = "0x1A379B0", Offset = "0x1A36BB0", Length = "0xA4C")]
	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32Enum&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TagValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180193510")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(ColorUtility), Member = "TryParseHtmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(RichTextTagParser), Member = "GetAttributeSpan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CF0A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RichTextTagParser), Member = "SpanToEnum", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(TagType&), typeof(String&), typeof(ReadOnlySpan`1<Char>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801CB6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ParseError), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	[Token(Token = "0x600000F")]
	internal static List<Tag> FindTags(string inputStr, List<ParseError> errors = null) { }

	[Address(RVA = "0x1A38400", Offset = "0x1A37600", Length = "0x299")]
	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	[Token(Token = "0x6000012")]
	internal static Segment[] GenerateSegments(string input, List<Tag> tags) { }

	[Address(RVA = "0x1A386A0", Offset = "0x1A378A0", Length = "0x1A6")]
	[CalledBy(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000010")]
	private static ReadOnlySpan<Char> GetAttributeSpan(ReadOnlySpan<Char> atributeSection) { }

	[Address(RVA = "0x1A38850", Offset = "0x1A37A50", Length = "0x8BE")]
	[CalledBy(Type = typeof(RichTextTagParser), Member = "ApplyStateToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>), typeof(Segment[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RichTextTagParser), Member = "CreateTextGenerationSettingsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextGenerationSettings&), typeof(System.Collections.Generic.List`1<System.ValueTuple`3<System.Int32, UnityEngine.TextCore.RichTextTagParser+TagType, System.String>>), typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Tag)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CF0A0")]
	[CallsDeduplicatedMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[NullableContext(1)]
	[Token(Token = "0x6000011")]
	internal static List<Tag> PickResultingTags(List<Tag> allTags, string input, int atPosition, List<Tag> applicableTags = null) { }

	[Address(RVA = "0x1A39110", Offset = "0x1A38310", Length = "0x3A6")]
	[CalledBy(Type = typeof(RichTextTagParser), Member = "FindTags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+ParseError>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.RichTextTagParser+Tag>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180193510")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180187B70")]
	[Calls(Type = typeof(System.ReadOnlySpan`1<System.Char>), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000E")]
	private static bool SpanToEnum(ReadOnlySpan<Char> tagCandidate, out TagType tagType, out string error, out ReadOnlySpan<Char>& attribute) { }

	[Address(RVA = "0x1A3A5F0", Offset = "0x1A397F0", Length = "0x146")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180193510")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000D")]
	private static bool tagMatch(ReadOnlySpan<Char> tagCandidate, string tagName) { }

}

