# graphicator
Library to help with complicated s&amp;box UI

## Current Usage
⚠️ Graphicator is in development. This is subject to change <3 ⚠️

### Wiggling squares example
```razor
@using Sandbox
@inherits Graphicator.Actor

<style>
	Test {
		top: @Game.Random.Int( 100 )%;
		left: @Game.Random.Int( 100 )%;
		width: 100px; height: 100px;
		background-color: red;
	}
</style>

@code {
	
	/// <summary>
	/// Override Act() instead of Tick() - you can change Position in here!
	/// If you want to change the Position outside of Act, use Modify()
	/// </summary>
	protected override void Act()
	{
		base.Act();

		// Move around the actor a little bit
		Position += Vector2.Random;
	}

}

```
