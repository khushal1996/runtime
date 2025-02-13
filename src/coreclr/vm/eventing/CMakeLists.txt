set(EVENT_MANIFEST ${VM_DIR}/ClrEtwAll.man)
set(EVENT_EXCLUSIONS ${VM_DIR}/ClrEtwAllMeta.lst)

if (CLR_CMAKE_HOST_WIN32)
  set(NONEXTERN_ARG "--nonextern")
  set(NOXPLATHEADER_ARG "--noxplatheader")
else()
  set(NEED_XPLAT_HEADER ON)
endif()

if (CLR_CMAKE_TARGET_LINUX)
  set(USEREVENTS_ARG "--userevents")
endif(CLR_CMAKE_TARGET_LINUX)

include(FindPython)

set (EventingHeaders
  ${GENERATED_INCLUDE_DIR}/etmdummy.h
  ${GENERATED_INCLUDE_DIR}/clretwallmain.h
  ${GENERATED_INCLUDE_DIR}/clreventpipewriteevents.h
  ${GENERATED_INCLUDE_DIR}/clrproviders.h
)

if (NEED_XPLAT_HEADER)
  list(APPEND EventingHeaders
    ${GENERATED_INCLUDE_DIR}/clrxplatevents.h)
endif()

set(GENEVENTING_SCRIPT ${CLR_DIR}/scripts/genEventing.py)

if(CMAKE_CROSSCOMPILING)
  set(GEN_EVENTING_TARGETOS --targetos)
  set(GEN_EVENTING_TARGETOS_ARG ${CLR_CMAKE_TARGET_OS})
endif()

add_custom_command(
  OUTPUT ${CMAKE_CURRENT_BINARY_DIR}/${CMAKE_CFG_INTDIR}/eventing_headers.timestamp
  COMMAND ${Python_EXECUTABLE} ${GENEVENTING_SCRIPT} --man ${EVENT_MANIFEST} --incdir ${GENERATED_INCLUDE_DIR} ${GEN_EVENTING_TARGETOS} ${GEN_EVENTING_TARGETOS_ARG} --dummy ${GENERATED_INCLUDE_DIR}/etmdummy.h ${NONEXTERN_ARG} ${NOXPLATHEADER_ARG} ${USEREVENTS_ARG}
  COMMAND ${CMAKE_COMMAND} -E touch ${CMAKE_CURRENT_BINARY_DIR}/${CMAKE_CFG_INTDIR}/eventing_headers.timestamp
  DEPENDS ${EVENT_MANIFEST} ${GENEVENTING_SCRIPT}
  VERBATIM
)

set_source_files_properties(${EventingHeaders} PROPERTIES GENERATED TRUE)

add_custom_target(eventing_headers DEPENDS ${CMAKE_CURRENT_BINARY_DIR}/${CMAKE_CFG_INTDIR}/eventing_headers.timestamp)
add_dependencies(eventing_headers eventprovider)

add_subdirectory(eventpipe)

if(CLR_CMAKE_TARGET_LINUX)
  add_subdirectory(userevents)
endif(CLR_CMAKE_TARGET_LINUX)

if(CLR_CMAKE_HOST_WIN32)
  add_subdirectory(EtwProvider)
endif()
