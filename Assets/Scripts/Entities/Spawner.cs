﻿using UnityEngine;
using Cyber.Console;

namespace Cyber.Entities {
    
    /// <summary>
    /// A utility class to spawn entities into the world based on 
    /// their <see cref="EntityType"/>.
    /// </summary>
    public class Spawner : MonoBehaviour {
        
        /// <summary>
        /// The <see cref="SyncDB"/> this <see cref="Spawner"/> should be using to
        /// set entities' IDs.
        /// </summary>
        public SyncDB SyncDB;

        /// <summary>
        /// The <see cref="EntityType.PC"/> prefab.
        /// </summary>
        public GameObject PCEntityPrefab;

        /// <summary>
        /// The <see cref="EntityType.NPC"/> prefab.
        /// </summary>
        public GameObject NPCEntityPrefab;

        /// <summary>
        /// Spawns an entity and returns that entity.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="position">Position.</param>
        /// <param name="ids">The ids of the entity's synced components. Should be
        /// set if they exist already (eg. the server has sent them over). These 
        /// ids should be from <see cref="SyncDB.GetEntityIDs"/>. To create new 
        /// ids, leave as the default (null).</param>
        public GameObject Spawn(EntityType type, Vector3 position, int[] ids = null) {
            GameObject Spawned = null;
            switch (type) {
            case EntityType.PC:
                Spawned = Instantiate(PCEntityPrefab, position, new Quaternion(), transform);
                break; 
            case EntityType.NPC:
                Spawned = Instantiate(NPCEntityPrefab, position, new Quaternion(), transform);
                break;
            }
            if (Spawned != null) {
                if (ids != null) {
                    SyncDB.AddEntity(Spawned, ids);
                } else {
                    SyncDB.AddEntity(Spawned, SyncDB.GetNewEntityIDs(Spawned));
                }
            }
            return Spawned;
        }

        /// <summary>
        /// Removes the gameobject that was given as an argument from the world.
        /// </summary>
        /// <param name="gameObject">Gameobject to be removed.</param>
        public void Remove(GameObject gameObject) {
            SyncDB.RemoveEntity(gameObject);
            Destroy(gameObject);
        }
    }
}