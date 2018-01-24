﻿/*
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at 
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 *  
 */

using System;
using java = biz.ritter.javapi;

namespace biz.ritter.javapi.lang.refj
{
     /*
     * Provides an abstract class which describes behavior common to all reference
     * objects. It is not possible to create immediate subclasses of
     * {@code Reference} in addition to the ones provided by this package. It is
     * also not desirable to do so, since references require very close cooperation
     * with the system's garbage collector. The existing, specialized reference
     * classes should be used instead.
     *
     * @since 1.2
     */
    public abstract class Reference<T> {

      /*
       * This class must be implemented by the vm vendor. The documented methods must
       * be implemented to support the provided subclass implementations. As the
       * provided subclass implementations are trivial and simply call
       * initReference(Object) and initReference(Object, ReferenceQueue) from their
       * constructors, the vm vendor may elect to implement the subclasses as well.
       * Abstract class which describes behavior common to all reference objects.
       */

         /*
         * Constructs a new instance of this class.
         * 
         */
        protected internal Reference() {
        }

         /*
         * Makes the referent {@code null}. This does not force the reference
         * object to be enqueued.
         */
        public virtual void clear() {
            return;
        }

         /*
         * Forces the reference object to be enqueued if it has been associated with
         * a queue.
         *
         * @return {@code true} if this call has caused the {@code Reference} to
         * become enqueued, or {@code false} otherwise
         */
        public virtual bool enqueue() {
            return false;
        }

       /*
       * Returns the referent of the reference object.
       *
       * @return the referent to which reference refers, or {@code null} if the
       *         object has been cleared.
       */
        public virtual T get() {
            return default(T);
        }

         /*
         * Checks whether the reference object has been enqueued.
         *
         * @return {@code true} if the {@code Reference} has been enqueued, {@code
         *         false} otherwise
         */
        public virtual bool isEnqueued() {
            return false;
        }

         /*
         * Implement this method to support the provided subclass implementations.
         * Initialize a newly created reference object. Associate the reference
         * object with the referent.
         * 
         * @param r the referent
         */
        protected internal virtual void initReference(Object r) {
            return;
        }

         /*
         * Implement this method to support the provided subclass implementations.
         * Initialize a newly created reference object. Associate the reference
         * object with the referent, and the specified ReferenceQueue.
         * 
         * @param r the referent
         * @param q the ReferenceQueue
         */
        protected internal virtual void initReference(Object r, ReferenceQueue<T> q) {
            return;
        }

         /*
         * Enqueue the reference object on the associated queue.
         * 
         * @return boolean true if the Reference was successfully enqueued. false
         *         otherwise.
         */
        protected internal virtual bool enqueueImpl() {
            return false;
        }

         /*
         * Called when a Reference has been removed from its ReferenceQueue. Set the
         * enqueued field to false.
         */
        protected internal virtual void dequeue() {
            return;
        }
    }
}
