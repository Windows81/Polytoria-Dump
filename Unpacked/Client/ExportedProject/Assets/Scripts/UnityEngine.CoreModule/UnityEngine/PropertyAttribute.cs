namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
[Token(Token = "0x200010C")]
[UsedByNativeCode]
public abstract class PropertyAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004F4")]
	private readonly bool <applyToCollection>k__BackingField; //Field offset: 0x10

	[Address(RVA = "0x196B950", Offset = "0x196AB50", Length = "0x1A")]
	[CalledBy(Type = "Polytoria.Lua.LuaCallbackParameter", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Lua.LuaEventParameter", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.CreatorProperty", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Archivable", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SyncVarAttribute", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SceneAttribute", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ReadOnlyAttribute", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000887")]
	protected PropertyAttribute() { }

	[Address(RVA = "0x2FE860", Offset = "0x2FDA60", Length = "0x26")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000888")]
	protected PropertyAttribute(bool applyToCollection) { }

}

