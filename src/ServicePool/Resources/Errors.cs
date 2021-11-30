﻿// Errors.cs
//
// This file is part of ServicePool
//
// Author(s):
//      César Morgan <xds_xps_ivx@hotmail.com>
//
// Copyright (C) 2021 César Andrés Morgan
//
// ServicePool is free software: you can redistribute it and/or modify it under the
// terms of the GNU General Public License as published by the Free Software
// Foundation, either version 3 of the License, or (at your option) any later
// version.
//
// ServicePool is distributed in the hope that it will be useful, but WITHOUT ANY
// WARRANTY, without even the implied warranty of MERCHANTABILITY or FITNESS FOR A
// PARTICULAR PURPOSE.  See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// this program. If not, see <http://www.gnu.org/licenses/>.

using System;
using Ers = TheXDS.ServicePool.Resources.Strings.Errors;

namespace TheXDS.ServicePool.Resources
{
    internal static class Errors
    {
        public static InvalidOperationException CantInstance()
        {
            return new InvalidOperationException(Ers.CantInstance);
        }
    }
}