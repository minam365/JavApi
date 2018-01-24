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

namespace biz.ritter.javapi.lang
{

 /*
 * Thrown when a program tries to access a class, interface, enum or annotation
 * type through a string that contains the type's name and the type cannot be
 * found. This exception is an unchecked alternative to
 * {@link java.lang.ClassNotFoundException}.
 *
 * @since 1.5
 */
public class TypeNotPresentException : RuntimeException {
    private const long serialVersionUID = -5101214195716534496L;

    private String typeNameJ;

     /*
     * Constructs a new {@code TypeNotPresentException} with the current stack
     * trace, a detail message that includes the name of the type that could not
     * be found and the {@code Throwable} that caused this exception.
     * 
     * @param typeName
     *            the fully qualified name of the type that could not be found.
     * @param cause
     *            the optional cause of this exception, may be {@code null}.
     */
    public TypeNotPresentException(String typeName, Throwable cause) :base
        ("Type " + typeName + " not present", cause){
        this.typeNameJ = typeName;
    }

     /*
     * Gets the fully qualified name of the type that could not be found.
     * 
     * @return the name of the type that caused this exception.
     */
    public String typeName() {
        return typeNameJ;
    }
}
}