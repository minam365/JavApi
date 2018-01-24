/*
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
 */
using System;
using java = biz.ritter.javapi;

namespace biz.ritter.javapi.io
{
	 /*
 * Signals a problem during the serialization or deserialization of an
 * object. Possible reasons include:
 * <ul>
 * <li>The SUIDs of the class loaded by the VM and the serialized class info do
 * not match.</li>
 * <li>A serializable or externalizable object cannot be instantiated (when
 * deserializing) because the no-arg constructor that needs to be run is not
 * visible or fails.</li>
 * </ul>
 * 
 * @see ObjectInputStream #readObject()
 * @see ObjectInputValidation#validateObject()
 */
	[Serializable]
	public class InvalidClassException : ObjectStreamException
	{

		private const long serialVersionUID = -4333316296251054416L;

		 /*
     * The fully qualified name of the class that caused the problem.
     */
		public String classname;

		 /*
     * Constructs a new {@code InvalidClassException} with its stack trace and
     * detailed message filled in.
     * 
     * @param detailMessage
     *            the detail message for this exception.
     */
		public InvalidClassException (String detailMessage) :
        base(detailMessage)
		{
		}

		 /*
     * Constructs a new {@code InvalidClassException} with its stack trace,
     * detail message and the fully qualified name of the class which caused the
     * exception filled in.
     * 
     * @param className
     *            the name of the class that caused the exception.
     * @param detailMessage
     *            the detail message for this exception.
     */
		public InvalidClassException (String className, String detailMessage) :
        base(detailMessage)
		{
			this.classname = className;
		}

		 /*
     * Returns the detail message which was provided when the exception was
     * created. {@code null} is returned if no message was provided at creation
     * time. If a detail message as well as a class name are provided, then the
     * values are concatenated and returned.
     * 
     * @return the detail message, possibly concatenated with the name of the
     *         class that caused the problem.
     */
    
		public override String getMessage ()
		{
			String msg = base.getMessage ();
			if (classname != null) {
				msg = classname + "; " + msg; //$NON-NLS-1$
			}
			return msg;
		}
	}
}