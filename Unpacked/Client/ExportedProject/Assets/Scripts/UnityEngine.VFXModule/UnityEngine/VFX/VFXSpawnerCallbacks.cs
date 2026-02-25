namespace UnityEngine.VFX;

[RequiredByNativeCode]
[Token(Token = "0x2000009")]
public abstract class VFXSpawnerCallbacks : ScriptableObject
{

	[Address(RVA = "0x40DB10", Offset = "0x40CD10", Length = "0x7")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	protected VFXSpawnerCallbacks() { }

	[Token(Token = "0x6000010")]
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Token(Token = "0x6000012")]
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

	[Token(Token = "0x6000011")]
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent) { }

}

