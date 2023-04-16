using System;
using Sandbox;
using Sandbox.UI;

namespace Graphicator;

public class Host : Panel
{
	public Camera Camera { get; } = new();

	protected override void OnChildAdded( Panel child )
	{
		base.OnChildAdded( child );

		if ( child is Actor actor )
			actor.Host = this;
	}
}
