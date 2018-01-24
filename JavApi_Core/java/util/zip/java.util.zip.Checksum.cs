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

namespace biz.ritter.javapi.util.zip
{

     /*
     * Holds information about a checksum which was computed with the methods
     * implementing a checksum algorithm.
     */
    public interface Checksum {

         /*
         * Returns the current calculated checksum value.
         *
         * @return the checksum.
         */
        long getValue();

         /*
         * Resets the checksum value applied before beginning calculations on a new
         * stream of data.
         */
        void reset();

         /*
         * Updates the checksum with the given bytes.
         *
         * @param buf
         *            the byte array from which to read the bytes.
         * @param off
         *            the initial position in {@code buf} to read the bytes from.
         * @param nbytes
         *            the number of bytes to read from {@code buf}.
         */
        void update(byte[] buf, int off, int nbytes);

         /*
         * Updates the checksum value with the given byte.
         *
         * @param val
         *            the byte to update the checksum with.
         */
        void update(int val);
    }
}
