












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Wait : ReqlExpr {

    
    
    
/// <summary>
/// <para>Wait for a table or all the tables in a database to be ready. A table may be temporarily unavailable after creation, rebalancing or reconfiguring. The <code>wait</code> command blocks until the given table (or database) is fully up to date.</para>
/// </summary>
/// <example><para>Example: Wait for a table to be ready.</para>
/// <code>&gt; r.table('superheroes').wait().run(conn, callback);
/// </code></example>
        public Wait (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Wait for a table or all the tables in a database to be ready. A table may be temporarily unavailable after creation, rebalancing or reconfiguring. The <code>wait</code> command blocks until the given table (or database) is fully up to date.</para>
/// </summary>
/// <example><para>Example: Wait for a table to be ready.</para>
/// <code>&gt; r.table('superheroes').wait().run(conn, callback);
/// </code></example>
        public Wait (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Wait for a table or all the tables in a database to be ready. A table may be temporarily unavailable after creation, rebalancing or reconfiguring. The <code>wait</code> command blocks until the given table (or database) is fully up to date.</para>
/// </summary>
/// <example><para>Example: Wait for a table to be ready.</para>
/// <code>&gt; r.table('superheroes').wait().run(conn, callback);
/// </code></example>
        public Wait (Arguments args, OptArgs optargs)
         : base(TermType.WAIT, args, optargs) {
        }


    



    
///<summary>
/// "wait_for": "E_STATUS",
///  "timeout": "T_NUM"
///</summary>
        public Wait this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new Wait (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "wait_for": "E_STATUS",
///  "timeout": "T_NUM"
///</summary>
    public Wait this[OptArgs optArgs] {
        get
        {
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
    
            return new Wait (this.Args, newOptargs);
        }
    }
    
///<summary>
/// "wait_for": "E_STATUS",
///  "timeout": "T_NUM"
///</summary>
        public Wait optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new Wait (this.Args, newOptargs);
        }


    

    


    
    }
}
