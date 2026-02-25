namespace UnityEngine.UIElements;

[Token(Token = "0x200000A")]
public struct BackgroundPosition : IEquatable<BackgroundPosition>
{
	[Token(Token = "0x200000B")]
	public class PropertyBag : ContainerPropertyBag<BackgroundPosition>
	{
		[Token(Token = "0x200000C")]
		private class KeywordProperty : Property<BackgroundPosition, BackgroundPositionKeyword>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400001A")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400001B")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000009")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6000036")]
				 get { } //Length: 5
			}

			[Token(Token = "0x17000008")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x6000035")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AB5530", Offset = "0x1AB4730", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x6000039")]
			public KeywordProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000036")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x6000035")]
			public virtual string get_Name() { }

			[Address(RVA = "0x418BB0", Offset = "0x417DB0", Length = "0x3")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000037")]
			public virtual BackgroundPositionKeyword GetValue(ref BackgroundPosition container) { }

			[Address(RVA = "0x1A189C0", Offset = "0x1A17BC0", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000038")]
			public virtual void SetValue(ref BackgroundPosition container, BackgroundPositionKeyword value) { }

		}

		[Token(Token = "0x200000D")]
		private class OffsetProperty : Property<BackgroundPosition, Length>
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400001C")]
			private readonly string <Name>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400001D")]
			private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x1700000B")]
			public virtual bool IsReadOnly
			{
				[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
				[CallerCount(Count = 0)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600003B")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700000A")]
			public virtual string Name
			{
				[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
				[CallerCount(Count = 18)]
				[CompilerGenerated]
				[DeduplicatedMethod]
				[Token(Token = "0x600003A")]
				 get { } //Length: 5
			}

			[Address(RVA = "0x1AB5760", Offset = "0x1AB4960", Length = "0x64")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[Token(Token = "0x600003E")]
			public OffsetProperty() { }

			[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
			[CallerCount(Count = 0)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600003B")]
			public virtual bool get_IsReadOnly() { }

			[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
			[CallerCount(Count = 18)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			[Token(Token = "0x600003A")]
			public virtual string get_Name() { }

			[Address(RVA = "0x1AB5740", Offset = "0x1AB4940", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003C")]
			public virtual Length GetValue(ref BackgroundPosition container) { }

			[Address(RVA = "0x1AB5750", Offset = "0x1AB4950", Length = "0x5")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600003D")]
			public virtual void SetValue(ref BackgroundPosition container, Length value) { }

		}


		[Address(RVA = "0x1AB5950", Offset = "0x1AB4B50", Length = "0x181")]
		[CalledBy(Type = typeof(UIElementsInitialization), Member = "RegisterBuiltInPropertyBags", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ContainerPropertyBag`1), Member = "AddProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.Property`2<TContainer, TValue>"}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x6000034")]
		public PropertyBag() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000018")]
	public BackgroundPositionKeyword keyword; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000019")]
	public Length offset; //Field offset: 0x4

	[Address(RVA = "0x1A928F0", Offset = "0x1A91AF0", Length = "0x33")]
	[CalledBy(Type = typeof(ShorthandApplicator), Member = "CompileBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyReader), typeof(BackgroundPosition&), typeof(BackgroundPosition&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "ReadBackgroundPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StylePropertyValue), typeof(StylePropertyValue), typeof(BackgroundPositionKeyword)}, ReturnType = typeof(BackgroundPosition))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x600002B")]
	public BackgroundPosition(BackgroundPositionKeyword keyword) { }

	[Address(RVA = "0x880BD0", Offset = "0x87FDD0", Length = "0x7")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002C")]
	public BackgroundPosition(BackgroundPositionKeyword keyword, Length offset) { }

	[Address(RVA = "0x1A92710", Offset = "0x1A91910", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1A926C0", Offset = "0x1A918C0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002F")]
	public override bool Equals(BackgroundPosition other) { }

	[Address(RVA = "0x1A927C0", Offset = "0x1A919C0", Length = "0x3B")]
	[CalledBy(Type = typeof(VisualData), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StyleBackgroundPosition), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000030")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A92800", Offset = "0x1A91A00", Length = "0x4E")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Length), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	internal static BackgroundPosition Initial() { }

	[Address(RVA = "0x1A92930", Offset = "0x1A91B30", Length = "0x64")]
	[CalledBy(Type = typeof(InlineStyleAccess), Member = "SetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(VisualData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualData), typeof(VisualData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundPosition), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundPosition), typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundPosition), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StyleBackgroundPosition)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleBackgroundPosition), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000031")]
	public static bool op_Equality(BackgroundPosition style1, BackgroundPosition style2) { }

	[Address(RVA = "0x1A929A0", Offset = "0x1A91BA0", Length = "0x67")]
	[CalledBy(Type = typeof(ComputedStyle), Member = "ApplyPropertyAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(StylePropertyId), typeof(BackgroundPosition)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "StartAnimationAllProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VisualElement), typeof(ComputedStyle&), typeof(ComputedStyle&), typeof(int), typeof(int), typeof(System.Func`2<System.Single, System.Single>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ComputedStyle), Member = "CompareChanges", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputedStyle&), typeof(ComputedStyle&)}, ReturnType = typeof(VersionChangeType))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000032")]
	public static bool op_Inequality(BackgroundPosition style1, BackgroundPosition style2) { }

	[Address(RVA = "0x1A92850", Offset = "0x1A91A50", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000033")]
	public virtual string ToString() { }

}

