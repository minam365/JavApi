/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements. See the NOTICE file distributed with this
 * work for additional information regarding copyright ownership. The ASF
 * licenses this file to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

namespace biz.ritter.javapi.lang.annotation
{
	 /*
 * Defines a meta-annotation for determining what {@link ElementType}s an
 * annotation can be applied to.
 * 
 * @see ElementType
 * @since 1.5
 */
	[Documented]
	[Retention (RetentionPolicy.RUNTIME)]
	[Target (ElementType.ANNOTATION_TYPE)]
	public class Target : AbstractAnnotation
	{
		private ElementType[] elementType;

		public Target (params ElementType[] types)
		{
			this.elementType = types;
		}

		 /*
     * Returns the program element types for which this annotation is applied.
     * 
     * @return the types of element as defined by {@code ElementType}
     */
		public virtual ElementType[] value ()
		{
			return this.elementType;
		}
	}
}