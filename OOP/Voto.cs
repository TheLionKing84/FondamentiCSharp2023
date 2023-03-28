﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Voto
    {
		private bool _lode;

		public bool Lode
		{
			get { return _lode; }
			set 
			{
				if (_punteggio < 30) 
					_lode = false;
				else
					_lode = value; 
			}
		}


		private int _punteggio;
		public int Punteggio
		{
			get 
			{ 
				return this._punteggio; 
			}
			set 
			{
				if (value > 30)
					this._punteggio = 30;
				else if (value < 0)
					this._punteggio = 0;
				else
					this._punteggio = value;

				if (_punteggio < 30) _lode = false;
			}
		}
	}
}
