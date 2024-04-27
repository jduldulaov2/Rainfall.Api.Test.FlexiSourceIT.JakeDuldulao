//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

/* tslint:disable */
/* eslint-disable */
// ReSharper disable InconsistentNaming

import { mergeMap as _observableMergeMap, catchError as _observableCatch } from 'rxjs/operators';
import { Observable, throwError as _observableThrow, of as _observableOf } from 'rxjs';
import { Injectable, Inject, Optional, InjectionToken } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpResponseBase } from '@angular/common/http';

export const API_BASE_URL = new InjectionToken<string>('API_BASE_URL');

export interface IRainfallClient {
    getParticularStation(stationId: number): Observable<ResultOfParticularStationDto>;
}

@Injectable({
    providedIn: 'root'
})
export class RainfallClient implements IRainfallClient {
    private http: HttpClient;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(@Inject(HttpClient) http: HttpClient, @Optional() @Inject(API_BASE_URL) baseUrl?: string) {
        this.http = http;
        this.baseUrl = baseUrl ?? "";
    }

    getParticularStation(stationId: number): Observable<ResultOfParticularStationDto> {
        let url_ = this.baseUrl + "/api/Rainfall/id/{StationId}/readings";
        if (stationId === undefined || stationId === null)
            throw new Error("The parameter 'stationId' must be defined.");
        url_ = url_.replace("{StationId}", encodeURIComponent("" + stationId));
        url_ = url_.replace(/[?&]$/, "");

        let options_ : any = {
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Accept": "application/json"
            })
        };

        return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processGetParticularStation(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processGetParticularStation(response_ as any);
                } catch (e) {
                    return _observableThrow(e) as any as Observable<ResultOfParticularStationDto>;
                }
            } else
                return _observableThrow(response_) as any as Observable<ResultOfParticularStationDto>;
        }));
    }

    protected processGetParticularStation(response: HttpResponseBase): Observable<ResultOfParticularStationDto> {
        const status = response.status;
        const responseBlob =
            response instanceof HttpResponse ? response.body :
            (response as any).error instanceof Blob ? (response as any).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }}
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = ResultOfParticularStationDto.fromJS(resultData200);
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap((_responseText: string) => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf(null as any);
    }
}

export class ResultOfParticularStationDto implements IResultOfParticularStationDto {
    data?: ParticularStationDto | undefined;
    message?: string;
    resultType?: ResultType;

    constructor(data?: IResultOfParticularStationDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.data = _data["data"] ? ParticularStationDto.fromJS(_data["data"]) : <any>undefined;
            this.message = _data["message"];
            this.resultType = _data["resultType"];
        }
    }

    static fromJS(data: any): ResultOfParticularStationDto {
        data = typeof data === 'object' ? data : {};
        let result = new ResultOfParticularStationDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["data"] = this.data ? this.data.toJSON() : <any>undefined;
        data["message"] = this.message;
        data["resultType"] = this.resultType;
        return data;
    }
}

export interface IResultOfParticularStationDto {
    data?: ParticularStationDto | undefined;
    message?: string;
    resultType?: ResultType;
}

export class ParticularStationDto implements IParticularStationDto {
    context?: string | undefined;
    meta?: MetaDto | undefined;

    constructor(data?: IParticularStationDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.context = _data["context"];
            this.meta = _data["meta"] ? MetaDto.fromJS(_data["meta"]) : <any>undefined;
        }
    }

    static fromJS(data: any): ParticularStationDto {
        data = typeof data === 'object' ? data : {};
        let result = new ParticularStationDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["context"] = this.context;
        data["meta"] = this.meta ? this.meta.toJSON() : <any>undefined;
        return data;
    }
}

export interface IParticularStationDto {
    context?: string | undefined;
    meta?: MetaDto | undefined;
}

export class MetaDto implements IMetaDto {
    publisher?: string | undefined;
    license?: string | undefined;
    documentation?: string | undefined;
    version?: string | undefined;
    comment?: string | undefined;

    constructor(data?: IMetaDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.publisher = _data["publisher"];
            this.license = _data["license"];
            this.documentation = _data["documentation"];
            this.version = _data["version"];
            this.comment = _data["comment"];
        }
    }

    static fromJS(data: any): MetaDto {
        data = typeof data === 'object' ? data : {};
        let result = new MetaDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["publisher"] = this.publisher;
        data["license"] = this.license;
        data["documentation"] = this.documentation;
        data["version"] = this.version;
        data["comment"] = this.comment;
        return data;
    }
}

export interface IMetaDto {
    publisher?: string | undefined;
    license?: string | undefined;
    documentation?: string | undefined;
    version?: string | undefined;
    comment?: string | undefined;
}

export enum ResultType {
    Success = 1,
    Warning = 2,
    Error = 3,
    Information = 4,
}

export class SwaggerException extends Error {
    override message: string;
    status: number;
    response: string;
    headers: { [key: string]: any; };
    result: any;

    constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
        super();

        this.message = message;
        this.status = status;
        this.response = response;
        this.headers = headers;
        this.result = result;
    }

    protected isSwaggerException = true;

    static isSwaggerException(obj: any): obj is SwaggerException {
        return obj.isSwaggerException === true;
    }
}

function throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): Observable<any> {
    if (result !== null && result !== undefined)
        return _observableThrow(result);
    else
        return _observableThrow(new SwaggerException(message, status, response, headers, null));
}

function blobToText(blob: any): Observable<string> {
    return new Observable<string>((observer: any) => {
        if (!blob) {
            observer.next("");
            observer.complete();
        } else {
            let reader = new FileReader();
            reader.onload = event => {
                observer.next((event.target as any).result);
                observer.complete();
            };
            reader.readAsText(blob);
        }
    });
}