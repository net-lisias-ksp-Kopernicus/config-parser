/**
 * Kopernicus ConfigNode Parser
 * -------------------------------------------------------------
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 *
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright of TakeTwo Interactive. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 *
 * https://kerbalspaceprogram.com
 */

namespace Kopernicus.ConfigParser.Interfaces
{
    /// <summary>
    /// Interface a class can implement to get events from the parser
    /// </summary>
    public interface IParserEventSubscriber
    {
        /// <summary>
        /// Apply Event - called after [PreApply] targets have been processed, but before the rest
        /// </summary>
        void Apply(ConfigNode node);

        /// <summary>
        /// Post Apply Event = called after all targets have been applied
        /// </summary>
        void PostApply(ConfigNode node);
    }
}