using System;
using System.Diagnostics;

namespace ShellTools.CommandLine
{
	/// <summary>
	/// Allows control of command line parsing.
	/// Attach this attribute to instance fields of types used
	/// as the destination of command line argument parsing.
	/// </summary>
	[AttributeUsage(AttributeTargets.Field)]
	public class ArgumentAttribute : Attribute
	{
		/// <summary>
		/// Allows control of command line parsing.
		/// </summary>
		/// <param name="type"> Specifies the error checking to be done on the argument. </param>
		public ArgumentAttribute(ArgumentType type)
		{
			this.type = type;
		}
        
		/// <summary>
		/// The error checking to be done on the argument.
		/// </summary>
		public ArgumentType Type
		{
			get { return this.type; }
		}
		/// <summary>
		/// Returns true if the argument did not have an explicit short name specified.
		/// </summary>
		public bool DefaultShortName    { get { return null == this.shortName; } }
        
		/// <summary>
		/// The short name of the argument.
		/// Set to null means use the default short name if it does not
		/// conflict with any other parameter name.
		/// Set to String.Empty for no short name.
		/// This property should not be set for DefaultArgumentAttributes.
		/// </summary>
		public string ShortName
		{
			get { return this.shortName; }
			set { Debug.Assert(value == null || !(this is DefaultArgumentAttribute)); this.shortName = value; }
		}

		/// <summary>
		/// Returns true if the argument did not have an explicit long name specified.
		/// </summary>
		public bool DefaultLongName     { get { return null == this.longName; } }
        
		/// <summary>
		/// The long name of the argument.
		/// Set to null means use the default long name.
		/// The long name for every argument must be unique.
		/// It is an error to specify a long name of String.Empty.
		/// </summary>
		public string LongName
		{
			get { Debug.Assert(!this.DefaultLongName); return this.longName; }
			set { Debug.Assert(value != ""); this.longName = value; }
		}

		/// <summary>
		/// The default value of the argument.
		/// </summary>
		public object DefaultValue
		{
			get { return this.defaultValue; }
			set { this.defaultValue = value; }
		}
        
		/// <summary>
		/// Returns true if the argument has a default value.
		/// </summary>
		public bool HasDefaultValue     { get { return null != this.defaultValue; } }

		/// <summary>
		/// Returns true if the argument has help text specified.
		/// </summary>
		public bool HasHelpText         { get { return null != this.helpText; } }
        
		/// <summary>
		/// The help text for the argument.
		/// </summary>
		public string HelpText
		{
			get { return this.helpText; }
			set { this.helpText = value; }
		}
        
		private string shortName;
		private string longName;
		private string helpText;
		private object defaultValue;
		private ArgumentType type;
	}
}