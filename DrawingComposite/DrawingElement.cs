﻿using System;

namespace DrawingComposite {
	abstract class DrawingElement {
		protected string _name;
		//C'tor
		public DrawingElement(string name) {
			this._name = name;
		}
		public abstract void Add(DrawingElement d);
		public abstract void Remove(DrawingElement d);
		public abstract void Display(int index);
	}
}