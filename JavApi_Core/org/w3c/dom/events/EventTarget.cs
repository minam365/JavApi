/*
 * Copyright (c) 1999 World Wide Web Consortium,
 * (Massachusetts Institute of Technology, Institut National de Recherche
 *  en Informatique et en Automatique, Keio University).
 * All Rights Reserved. http://www.w3.org/Consortium/Legal/
 */
using System;

namespace org.w3c.dom.events
{

     /*
     * The <code>EventTarget</code> interface is implemented by all 
     * <code>Node</code>s in  an implementation which supports the DOM Event 
     * Model.  The interface allows registration and removal of 
     * <code>EventListener</code>s on an <code>EventTarget</code> and dispatch of 
     * events to that <code>EventTarget</code>.
     * @since DOM Level 2
     */
    public interface EventTarget
    {
         /*
         * This method allows the registration of event listeners on the event 
         * target.  
         * @param type The event type for which the user is registering
         * @param listener The <code>listener</code> parameter takes an interface 
         *   implemented by the user which contains the methods to be called when 
         *   the event occurs.
         * @param useCapture If true, <code>useCapture</code> indicates that the 
         *   user wishes to initiate capture.  After initiating capture, all events 
         *   of the specified type will be  dispatched to the registered 
         *   <code>EventListener</code> before being dispatched to any 
         *   <code>EventTarget</code>s beneath them in the tree.  Events which are 
         *   bubbling upward through the tree will not trigger an 
         *   <code>EventListener</code> designated to use capture.If an 
         *   <code>EventListener</code> is added to an <code>EventTarget</code> 
         *   which is  currently processing an event the new listener will not be 
         *   triggered by the current event.
         */
         void addEventListener(String type,
                                                   EventListener listener,
                                                   bool useCapture);
         /*
         * This method allows the removal of event listeners from the event target.  
         * If an <code>EventListener</code> is removed from an 
         * <code>EventTarget</code> while it is  processing an event, it will 
         * complete its current actions but will not be triggered again during any 
         * later stages of event flow.
         * <br>If an <code>EventListener</code> is removed from an 
         * <code>EventTarget</code> which is  currently processing an event the 
         * removed listener will still be triggered by the current event.
         * @param type Specifies the event type of the <code>EventListener</code> 
         *   being removed. 
         * @param listener The <code>EventListener</code> parameter indicates the 
         *   <code>EventListener </code> to be removed. 
         * @param useCapture Specifies whether the <code>EventListener</code> being 
         *   removed was registered as a capturing listener or not.  If a listener 
         *   was registered twice, one with capture and one without, each must be 
         *   removed separately.  Removal of a capturing listener does not affect a 
         *   non-capturing version of the same listener, and vice versa. 
         */
         void removeEventListener(String type,
                                                      EventListener listener,
                                                      bool useCapture);
         /*
         * This method allows the dispatch of events into the implementations event 
         * model.  Events dispatched in this manner will have the same capturing 
         * and bubbling behavior as events dispatched directly by the 
         * implementation.  The target of the event is the <code> EventTarget</code>
         *  on which <code>dispatchEvent</code> is called. 
         * @param evt Specifies the event type, behavior, and contextual information 
         *   to be used in processing the event.
         * @return The return value of <code>dispatchEvent</code> indicates whether 
         *   any of the listeners which handled the event called 
         *   <code>preventDefault</code>.  If <code>preventDefault</code> was 
         *   called the value is false, else the value is true. 
         * @exception DOMException
         *   UNSPECIFIED_EVENT_TYPE: Raised if the <code>Event</code>'s type was 
         *   not specified by initializing the event before 
         *   <code>dispatchEvent</code> was called.
         */
         bool dispatchEvent(Event evt);//                                          throws DOMException;
    }

}