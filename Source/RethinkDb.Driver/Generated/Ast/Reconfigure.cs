














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Reconfigure : ReqlExpr {

    
    
    
/// <summary>
/// <para>Reconfigure a table's sharding and replication.</para>
/// </summary>
/// <example><para>Example: Reconfigure a table.</para>
/// <code>&gt; r.table('superheroes').reconfigure({shards: 2, replicas: 1}).run(conn, callback);
/// </code></example>
        public Reconfigure (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Reconfigure a table's sharding and replication.</para>
/// </summary>
/// <example><para>Example: Reconfigure a table.</para>
/// <code>&gt; r.table('superheroes').reconfigure({shards: 2, replicas: 1}).run(conn, callback);
/// </code></example>
        public Reconfigure (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Reconfigure a table's sharding and replication.</para>
/// </summary>
/// <example><para>Example: Reconfigure a table.</para>
/// <code>&gt; r.table('superheroes').reconfigure({shards: 2, replicas: 1}).run(conn, callback);
/// </code></example>
        public Reconfigure (Arguments args, OptArgs optargs)
         : base(TermType.RECONFIGURE, args, optargs) {
        }


    



    
///<summary>
/// "shards": "T_NUM",
///  "replicas": [
///    "T_OBJECT",
///    "T_NUM"
///  ],
///  "primary_replica_tag": "T_STR",
///  "dry_run": "T_BOOL",
///  "nonvoting_replica_tags": "T_ARRAY",
///  "emergency_repair": "E_EMERGENCY_REPAIR"
///</summary>
        public Reconfigure this[object optArgs] {
            get
            {
                var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
        
                return new Reconfigure (this.Args, newOptArgs);
            }
        }
        
///<summary>
/// "shards": "T_NUM",
///  "replicas": [
///    "T_OBJECT",
///    "T_NUM"
///  ],
///  "primary_replica_tag": "T_STR",
///  "dry_run": "T_BOOL",
///  "nonvoting_replica_tags": "T_ARRAY",
///  "emergency_repair": "E_EMERGENCY_REPAIR"
///</summary>
    public Reconfigure this[OptArgs optArgs] {
        get
        {
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(optArgs);
    
            return new Reconfigure (this.Args, newOptArgs);
        }
    }
    
///<summary>
/// "shards": "T_NUM",
///  "replicas": [
///    "T_OBJECT",
///    "T_NUM"
///  ],
///  "primary_replica_tag": "T_STR",
///  "dry_run": "T_BOOL",
///  "nonvoting_replica_tags": "T_ARRAY",
///  "emergency_repair": "E_EMERGENCY_REPAIR"
///</summary>
        public Reconfigure optArg(string key, object val){
            
            var newOptArgs = OptArgs.FromMap(this.OptArgs).With(key, val);
        
            return new Reconfigure (this.Args, newOptArgs);
        }


    

    
        /// <summary>
        /// Get a single field from an object. If called on a sequence, gets that field from every object in the sequence, skipping objects that lack it.
        /// </summary>
        /// <param name="bracket"></param>
        public new Bracket this[string bracket] => base[bracket];
        
        /// <summary>
        /// Get the nth element of a sequence, counting from zero. If the argument is negative, count from the last element.
        /// </summary>
        /// <param name="bracket"></param>
        /// <returns></returns>
        public new Bracket this[int bracket] => base[bracket];


    

    


    
    }
}
