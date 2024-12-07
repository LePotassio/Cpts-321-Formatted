﻿// <copyright file="SSCell.cs" company="Eric-Furukawa">
// Copyright (c) Eric-Furukawa. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpts321
{
    /// <summary>
    /// Instantiable cell which is limited to instantiation in only the Spreadsheet class.
    /// </summary>
    internal class SSCell : Cell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSCell"/> class.
        /// </summary>
        /// <param name="row">Row for rowindex to be set to.</param>
        /// <param name="col">Column for columnindex to be set to.</param>
        public SSCell(int row, int col)
            : base(row, col)
        {
        }
    }
}
