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

namespace biz.ritter.javapi.lang{

	 /*
	 * Thrown by the virtual machine when an abstract method is called.
	 * <p>
	 * Note that this can only occur when inconsistent class files have been loaded,
	 * since invoking an abstract method is a compile time error.
	 */
	public class AbstractMethodError : IncompatibleClassChangeError {

	    private const long serialVersionUID = -1654391082989018462L;

	     /*
	     * Constructs a new {@code AbstractMethodError} that includes the current
	     * stack trace.
	     */
	    public AbstractMethodError() :base(){
	        
	    }

	     /*
	     * Constructs a new {@code AbstractMethodError} with the current stack trace
	     * and the specified detail message.
	     *
	     * @param detailMessage
	     *            the detail message for this error.
	     */
	    public AbstractMethodError(String detailMessage) : base(detailMessage) {
	    }
	}
}