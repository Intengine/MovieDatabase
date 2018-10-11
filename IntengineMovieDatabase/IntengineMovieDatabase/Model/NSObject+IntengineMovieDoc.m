//
//  NSObject+IntengineMovieDoc.m
//  IntengineMovieDatabase
//
//  Created by Sylwester Pilarz on 11/10/2018.
//  Copyright © 2018 Intengine. All rights reserved.
//

#import "NSObject+IntengineMovieDoc.h"
#import "NSObject+IntengineMovieData.h"

@implementation IntengineMovieDoc

- (id)initWithTitle:(NSString *)title rating:(float)rating thumbImage:(NSImage *)thumbImage fullImage:(NSImage *)fullImage {
    if ((self = [super init])) {
        self.data = [[IntengineMovieData alloc] initWithTitle:title rating:rating];
        self.thumbImage = thumbImage;
        self.fullImage = fullImage;
    }
    return self;
}

@end
