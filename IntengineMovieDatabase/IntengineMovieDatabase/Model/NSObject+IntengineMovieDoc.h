//
//  NSObject+IntengineMovieDoc.h
//  IntengineMovieDatabase
//
//  Created by Sylwester Pilarz on 11/10/2018.
//  Copyright © 2018 Intengine. All rights reserved.
//

#import <Foundation/Foundation.h>

@class IntengineMovieData;
@interface IntengineMovieDoc : NSObject

@property (strong) IntengineMovieData *data;
@property (strong) NSImage *thumbImage;
@property (strong) NSImage *fullImage;

- (id)initWithTitle:(NSString*)title rating:(float)rating thumbImage:(NSImage*)thumbImage fullImage:(NSImage*)fullImage;

@end
